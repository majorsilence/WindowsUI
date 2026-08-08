using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsUI.Design
{
    class Shadow
    {
        public static void AddShadow(IntPtr HWnd)
        {
            // CS_DROPSHADOW is a Win32 window-class style; nothing to do off Windows.
            if (!OperatingSystem.IsWindows())
                return;

            WinAPI.SetClassLong(HWnd, Constants.GCL_STYLE, WinAPI.GetClassLong(HWnd, Constants.GCL_STYLE) | Constants.CS_DropSHADOW);
        }
    }
}
