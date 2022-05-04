#pragma once
#undef _ARM_WINAPI_PARTITION_DESKTOP_SDK_AVAILABLE
#define _ARM_WINAPI_PARTITION_DESKTOP_SDK_AVAILABLE 1
#undef WINAPI_FAMILY
#define WINAPI_FAMILY WINAPI_FAMILY_DESKTOP_APP
#define _WIN32_WINNT 0x0603	// Windows 8.1
#include <bthdef.h>
#include <fileapi.h>
#include <rpcdce.h>
#include <string.h>
#include <hidsdi.h>

extern "C" {
	WINBASEAPI
		DWORD
		WINAPI
		QueryDosDeviceW(
			_In_opt_ LPCWSTR lpDeviceName,
			_Out_writes_to_opt_(ucchMax, return) LPWSTR lpTargetPath,
			_In_ DWORD ucchMax
		);

	RPCRTAPI
		_Must_inspect_result_
		RPC_STATUS
		RPC_ENTRY
		UuidFromStringW(
			_In_opt_ RPC_WSTR StringUuid,
			_Out_ UUID __RPC_FAR * Uuid
		);

	RPCRTAPI
		_Must_inspect_result_
		RPC_STATUS
		RPC_ENTRY
		UuidToStringW(
			_In_ const UUID __RPC_FAR * Uuid,
			_Outptr_ RPC_WSTR __RPC_FAR * StringUuid
		);

	WINBASEAPI
		HANDLE
		WINAPI
		CreateFileA(
			_In_ LPCSTR lpFileName,
			_In_ DWORD dwDesiredAccess,
			_In_ DWORD dwShareMode,
			_In_opt_ LPSECURITY_ATTRIBUTES lpSecurityAttributes,
			_In_ DWORD dwCreationDisposition,
			_In_ DWORD dwFlagsAndAttributes,
			_In_opt_ HANDLE hTemplateFile
		);

	WINBASEAPI
		BOOL
		WINAPI
		GetOverlappedResult(
			_In_ HANDLE hFile,
			_In_ LPOVERLAPPED lpOverlapped,
			_Out_ LPDWORD lpNumberOfBytesTransferred,
			_In_ BOOL bWait
		);
}

typedef std::vector<UCHAR> DataBuffer;

namespace Wiimote
{
	enum
	{
		BUTTON_LEFT = 0x0800,
		BUTTON_RIGHT = 0x0400,
		BUTTON_UP = 0x0200,
		BUTTON_DOWN = 0x0100,
		BUTTON_A = 0x0008,
		BUTTON_B = 0x0004,
		BUTTON_PLUS = 0x1000,
		BUTTON_HOME = 0x0080,
		BUTTON_MINUS = 0x0010,
		BUTTON_ONE = 0x0002,
		BUTTON_TWO = 0x0001
	};

	class Controller
	{
	public:
		static Controller *GetInstance(void);

		Controller(void);
		~Controller(void);

		void start();
		void stop();
		DWORD getState();

		void Debug(const char * format, ...);

		HANDLE findDeviceHandle();

		void setLEDs(HANDLE hDevice, UCHAR flag);

		void writeData(HANDLE hDevice, DataBuffer buffer);

		void setDataReportingMode(HANDLE hDevice, UCHAR modeNumber);

		DWORD *state;
	private:
		static Controller *singleton;
		HANDLE hdevice;

	};
}