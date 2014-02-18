#pragma once

#include "pch.h"
#include "BasicTimer.h"
#include "EmulatorRenderer.h"
#include "VirtualController.h"
#include "EmulatorSettings.h"
#include "EmulatorFileHandler.h"
#include "CheatData.h"
#include <DrawingSurfaceNative.h>
#include "Delegates.h"

using namespace Emulator;
using namespace Windows::ApplicationModel;

namespace PhoneDirect3DXamlAppComponent
{


[Windows::Foundation::Metadata::WebHostHidden]
public ref class LinkDirect3DBackground sealed : public Windows::Phone::Input::Interop::IDrawingSurfaceManipulationHandler
{	
public:
	LinkDirect3DBackground();

	Windows::Phone::Graphics::Interop::IDrawingSurfaceBackgroundContentProvider^ CreateContentProvider();

	// IDrawingSurfaceManipulationHandler
	virtual void SetManipulationHost(Windows::Phone::Input::Interop::DrawingSurfaceManipulationHost^ manipulationHost);

	event RequestAdditionalFrameHandler^ RequestAdditionalFrame;

	property StorageFile ^LoadadROMFile
	{
		StorageFile ^get()
		{
			return ROMFile;
		}
	}

	property StorageFile ^LoadadROMFile2
	{
		StorageFile ^get()
		{
			return ROMFile2;
		}
	}

	property int SelectedSavestateSlot
	{
		int get()
		{
			return SavestateSlot;
		}
	}

	property int SelectedSavestateSlot2
	{
		int get()
		{
			return SavestateSlot2;
		}
	}

	property SavestateSelectedCallback ^SavestateSelected;
	property SnapshotCallback ^SnapshotAvailable;
	property SavestateCreatedCallback ^SavestateCreated;
	property Windows::Foundation::Size WindowBounds;
	property Windows::Foundation::Size NativeResolution;
	property Windows::Foundation::Size RenderResolution;

	void ToggleTurboMode(void);
	void StartTurboMode(void);
	void StopTurboMode(void);

	void TriggerSnapshot(void);

	void LoadCheatsOnROMLoad(Windows::Foundation::Collections::IVector<CheatData ^> ^cheats);
	void LoadCheats(Windows::Foundation::Collections::IVector<CheatData ^> ^cheats);
	void SelectSaveState(int slot);
	void SaveState(void);
	void LoadState(int slot);
	void Reset(void);
	void SetContinueNotifier(ContinueEmulationNotifier ^notifier);

	void ChangeOrientation(int orientation);
	bool IsROMLoaded(void);
	void PauseEmulation(void);
	void UnpauseEmulation(void);
	void LoadROMAsync(Windows::Storage::StorageFile ^file, Windows::Storage::StorageFolder ^folder);

	static Moga::Windows::Phone::ControllerManager^ getController() {
		return mogacontroller;
	};
	

protected:
	// Event Handlers
	void OnPointerPressed(Windows::Phone::Input::Interop::DrawingSurfaceManipulationHost^ sender, Windows::UI::Core::PointerEventArgs^ args);
	void OnPointerReleased(Windows::Phone::Input::Interop::DrawingSurfaceManipulationHost^ sender, Windows::UI::Core::PointerEventArgs^ args);
	void OnPointerMoved(Windows::Phone::Input::Interop::DrawingSurfaceManipulationHost^ sender, Windows::UI::Core::PointerEventArgs^ args);

internal:
	HRESULT Connect(_In_ IDrawingSurfaceRuntimeHostNative* host, _In_ ID3D11Device1* device);
	void Disconnect();

	HRESULT PrepareResources(_In_ const LARGE_INTEGER* presentTargetTime, _Inout_ DrawingSurfaceSizeF* desiredRenderTargetSize);
	HRESULT Draw(_In_ ID3D11Device1* device, _In_ ID3D11DeviceContext1* context, _In_ ID3D11RenderTargetView* renderTargetView);

private:
	ContinueEmulationNotifier ^ContinueEmulationNotifier;
	EmulatorRenderer^ m_renderer;
	BasicTimer^ m_timer;
	EmulatorGame *emulator;
	VirtualController *vController;
	static Moga::Windows::Phone::ControllerManager^ mogacontroller;
	int orientation;
	HANDLE waitEvent;
};

}