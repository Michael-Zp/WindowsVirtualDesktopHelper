// Original Implemation: windows-virtualdesktopindicator by zgdump (https://github.com/zgdump/windows-virtualdesktopindicator)
// Contributors: Dan Krusi (https://github.com/dankrusi), MScholtes (https://github.com/MScholtes), Flaflo (https://github.com/Flaflo)
// License: MIT License (https://github.com/zgdump/windows-virtualdesktopindicator/blob/main/LICENSE)

using System;
using System.Collections.Generic;

namespace WindowsVirtualDesktopHelper.VirtualDesktopAPI {
	public interface IVirtualDesktopAPI {
		uint Current();

		void SwitchForward();

		void SwitchToDesktop(string name);

		void SwitchBackward();

		string CurrentDisplayName();

		void RenameDesktop(int index, string newName);

		List<string> GetAllDesktopNames();

		void MoveCurrentWindowToDesktop(IntPtr hWnd, string name);
	}
}
