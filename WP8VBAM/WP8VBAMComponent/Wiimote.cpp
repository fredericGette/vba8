#include "pch.h"
#include <ppltasks.h>
#include "Wiimote.h"

#pragma comment(lib,"RPCRT4.lib") 
#pragma comment(lib,"hid.lib") 

namespace Wiimote
{

	Controller *Controller::singleton = nullptr;
	HANDLE hDevice = INVALID_HANDLE_VALUE;
	DWORD *state = nullptr;

	Controller * Controller::GetInstance(void)
	{
		if (singleton == nullptr)
		{
			new Controller();
		}
		return singleton;
	}

	Controller::Controller(void)
	{
		singleton = this;
		state = new DWORD;
		*state = 0;
	}

	Controller::~Controller(void)
	{
		stop();
	}

	void Controller::start()
	{
		hDevice = findDeviceHandle();

		// LED 1 = 0x10
		setLEDs(hDevice, 0x10);

		// Core Buttons = 0x30
		setDataReportingMode(hDevice, 0x30);

		concurrency::create_task([this]()
		{
			// Read data
			UCHAR Buffer[255];
			DWORD BytesRead;
			while (true) {
				BOOL Result = ReadFile(hDevice, &Buffer, sizeof(Buffer), &BytesRead, NULL);
				if (!Result)
				{
					Debug("Error ReadFile: %d\n", GetLastError());
				}

				Wiimote::Controller *WiiController = Wiimote::Controller::GetInstance();
				*(this->state) = (Buffer[1] << 8) + Buffer[2];
				//Debug("%04X ", *(this->state));
			}
		});
	}

	void Controller::stop()
	{
		CloseHandle(hDevice);
	}

	DWORD Controller::getState()
	{
		return *(this->state);
	}


	void Controller::Debug(const char* format, ...)
	{
		va_list args;
		va_start(args, format);

		char buffer[100];
		vsnprintf_s(buffer, sizeof(buffer), format, args);

		OutputDebugStringA(buffer);

		va_end(args);
	}

	HANDLE Controller::findDeviceHandle()
	{
		// Construct the expected device name (the first part seems to be enough):
		// HID#<UUID_HID_SERVICE>_LOCALMFG&<QUALCOMM>#7&3a273ef&0&0000#<GUID_DEVINTERFACE_HID>
		RPC_WSTR wcharUuid;
		UuidToStringW(&HumanInterfaceDeviceServiceClass_UUID, &wcharUuid);
		std::wstring wstringStartDeviceName = L"HID#{";
		wstringStartDeviceName += std::wstring((WCHAR*)wcharUuid);
		wstringStartDeviceName += L"}";

		// List all devices
		WCHAR devicenames[100 * MAX_PATH] = L"";
		DWORD resultQDD = QueryDosDeviceW(NULL, devicenames, ARRAYSIZE(devicenames));
		if (resultQDD == ERROR_SUCCESS)
		{
			Debug("QueryDosDeviceW failed with error code %d\n", GetLastError());
		}

		// Find the device having the expected name and corresponding to a Nintendo device

		HANDLE hDevice = INVALID_HANDLE_VALUE;
		WCHAR * deviceName = devicenames;
		for (DWORD i = 0; i < resultQDD; i++) {
			if (devicenames[i] == '\0') {
				if (wcsncmp(deviceName, wstringStartDeviceName.c_str(), wstringStartDeviceName.length()) == 0)
				{
					Debug("HumanInterfaceDeviceServiceClass_UUID found:\n\t");
					OutputDebugString(deviceName);
					OutputDebugString(L"\n");

					std::wstring wstringDeviceName(deviceName);
					std::string stringDeviceName(wstringDeviceName.begin(), wstringDeviceName.end());
					std::string stringDeviceFileName = "\\\\.\\" + stringDeviceName;

					Debug("Open device file: ");	OutputDebugStringA(stringDeviceFileName.c_str()); Debug("\n");
					DWORD desired_access = GENERIC_READ | GENERIC_WRITE;
					DWORD share_mode = FILE_SHARE_READ | FILE_SHARE_WRITE;
					hDevice = CreateFileA(stringDeviceFileName.c_str(),
						desired_access,
						share_mode,
						NULL,
						OPEN_EXISTING,
						FILE_ATTRIBUTE_NORMAL,
						NULL);
					if (hDevice == INVALID_HANDLE_VALUE)    // cannot open the device file
					{
						Debug("Error CreateFileA: %d\n", GetLastError());
					}
					else
					{
						WCHAR ProductName[255];
						ZeroMemory(ProductName, sizeof(ProductName));

						if (HidD_GetProductString(hDevice, ProductName, 255))
						{
							Debug("HID Name: "); OutputDebugString(ProductName); Debug("\n");

							if (wcsncmp(ProductName, L"Nintendo", 8) == 0)
							{
								Debug("Wiimote found.\n");
								break;
							}
							else
							{
								Debug("Wiimote not detect. Please check that Wiimote is on. Press buttons 1+2.\n");
							}
						}
						else
						{
							Debug("Can not check the product name of the HID device.\n");
						}
					}
				}

				// next device name
				deviceName = devicenames + i + 1;
			}
		}

		if (hDevice != INVALID_HANDLE_VALUE)
		{


			PHIDP_PREPARSED_DATA PreparsedData = NULL;
			BOOL Result = HidD_GetPreparsedData(hDevice, &PreparsedData);
			if (!Result)
			{
				Debug("Error HidD_GetPreparsedData: %d\n", Result);
			}

			HIDP_CAPS Caps;
			NTSTATUS Status = HidP_GetCaps(PreparsedData, &Caps);
			if (Status < 0)
			{
				Debug("Error HidP_GetCaps: %d\n", Status);
				HidD_FreePreparsedData(PreparsedData);
			}

			Debug("Capabilities:\n");
			Debug("\tUsage (0x05 = Game Pad): 0x%X\n", Caps.Usage); // https://docs.microsoft.com/en-us/windows-hardware/drivers/hid/hid-usages#usage-id
			Debug("\tUsagePage (0x01 = Generic Desktop Controls): 0x%X\n", Caps.UsagePage); // https://docs.microsoft.com/en-us/windows-hardware/drivers/hid/hid-usages#usage-page
			Debug("\tInputReportByteLength: %d\n", Caps.InputReportByteLength);
			Debug("\tOutputReportByteLength: %d\n", Caps.OutputReportByteLength);
			Debug("\tFeatureReportByteLength: %d\n", Caps.FeatureReportByteLength);

			HidD_FreePreparsedData(PreparsedData);
		}

		return hDevice;
	}

	// https://wiibrew.org/wiki/Wiimote/Protocol#Player_LEDs
	// report id=0x11, set LEDs
	// LEDs 2&3 = 0x20+0x40=0x60
	// LED 1 = 0x10
	// LED 4 = 0x80
	void Controller::setLEDs(HANDLE hDevice, UCHAR flag) {

		DataBuffer BufferSetLED({ 0x11, flag });

		writeData(hDevice, BufferSetLED);
	}

	void Controller::writeData(HANDLE hDevice, DataBuffer buffer) {
		DWORD BytesWritten;
		BOOL Result = WriteFile(hDevice, buffer.data(), (DWORD)buffer.size(), &BytesWritten, NULL);
		if (!Result)
		{
			DWORD Error = GetLastError();
			Debug("Error WriteFile (997 = ERROR_IO_PENDING): %d\n", Error);
		}
	}

	// MM = mode number, 0x30: Core Buttons
	void Controller::setDataReportingMode(HANDLE hDevice, UCHAR modeNumber) {

		// report id=0x12, set Data Reporting mode
		// TT MM
		// TT = 0 no continuous reporting, report only when data has changed
		// MM = mode number, 0x30: Core Buttons
		DataBuffer BufferSetDataReportingMode({ 0x12, 0x00, 0x30 });

		writeData(hDevice, BufferSetDataReportingMode);
	}

}