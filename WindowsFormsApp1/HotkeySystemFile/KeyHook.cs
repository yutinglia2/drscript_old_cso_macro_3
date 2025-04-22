using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WindowsFormsApp1
{
    /// <summary>
    /// <para>
    ///     Hotkey System : KeyHook
    /// </para>
    /// <para>
    ///     Written by : Lai Yu Ting
    /// </para>
    /// <para>
    ///     Latest update : 20/9/2020 18:21
    /// </para>
    /// </summary>
    public class KeyHook
    {

        //*************************************************************************************************
        //
        //  DllImport
        //
        //*************************************************************************************************

        //安装鉤子
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);
        //卸载鉤子
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);
        //继续下一个鉤子
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode, Int32 wParam, IntPtr lParam);
        //模擬按键消息
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        [DllImport("kernel32.dll")]
        static extern int GetCurrentThreadId();

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string name);

        //*************************************************************************************************
        //*************************************************************************************************




        //*************************************************************************************************
        //
        //  variable
        //
        //*************************************************************************************************

        private const int WM_KEYDOWN = 0x100;//KEYDOWN
        private const int WM_KEYUP = 0x101;//KEYUP
        private const int WM_SYSKEYDOWN = 0x104;//SYSKEYDOWN
        private const int WM_SYSKEYUP = 0x105;//SYSKEYUP

        private const int WM_LBUTTONDOWN = 0x201;
        private const int WM_RBUTTONDOWN = 0x204;
        private const int WM_XBUTTONDOWN = 0x020B;
        private const int WM_MBUTTONDOWN = 0x0207;

        public int keyCode = 0;
        private int mouseDown = 0;
        private int mouseUp = 0;
        private int xButton = 0;
        private IKeyboardHookListener listener; // callback

        public bool blockOriginalInput = false;

        public delegate int HookProc(int nCode, Int32 wParam, IntPtr lParam);
        private int hKeyboardHook = 0;
        private int hMouseHook = 0;
        public const int WH_KEYBOARD_LL = 13;
        public const int WH_MOUSE_LL = 14;

        private HookProc KeyboardHookProcedure;
        private HookProc MouseHookProcedure;

        //*************************************************************************************************
        //*************************************************************************************************




        //*************************************************************************************************
        //
        //  struct class
        //
        //*************************************************************************************************

        [StructLayout(LayoutKind.Sequential)]
        public class KeyboardHookStruct
        {
            public int vkCode;  
            public int scanCode; 
            public int flags;  
            public int time; 
            public int dwExtraInfo; 
        }

        [StructLayout(LayoutKind.Sequential)]
        public class POINT
        {
            public int x;
            public int y;
        }
        //Decla

        [StructLayout(LayoutKind.Sequential)]
        public class MouseHookStruct
        {
            public POINT pt;
            public int hwnd;
            public int wHitTestCode;
            public int dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        //*************************************************************************************************
        //*************************************************************************************************




        //*************************************************************************************************
        //
        //  program
        //
        //*************************************************************************************************

        //=================================================================================================
        //  constructor
        //=================================================================================================
        public KeyHook(IKeyboardHookListener listener)
        {
            this.keyCode = 0; // default keyCode 0
            this.listener = listener; // set callback listener
        }
        //=================================================================================================



        //=================================================================================================
        //  set key
        //=================================================================================================
        public void setKey(int keyCode)
        {
            switch (keyCode)
            {
                // mouse left click
                case 1:
                    mouseDown = WM_LBUTTONDOWN;
                    mouseUp = mouseDown + 1;
                    xButton = 0;
                    this.keyCode = 0;
                    break;
                // mouse right click
                case 2:
                    mouseDown = WM_RBUTTONDOWN;
                    mouseUp = mouseDown + 1;
                    xButton = 0;
                    this.keyCode = 0;
                    break;
                // mouse middle click
                case 4:
                    mouseDown = WM_MBUTTONDOWN;
                    mouseUp = mouseDown + 1;
                    xButton = 0;
                    this.keyCode = 0;
                    break;
                // mouse side click 1
                case 5:
                    mouseDown = WM_XBUTTONDOWN;
                    mouseUp = mouseDown + 1;
                    xButton = 1;
                    this.keyCode = 0;
                    break;
                // mouse side click 2
                case 6:
                    mouseDown = WM_XBUTTONDOWN;
                    mouseUp = mouseDown + 1;
                    xButton = 2;
                    this.keyCode = 0;
                    break;
                // keyboard
                default:
                    mouseDown = 0;
                    xButton = 0;
                    this.keyCode = keyCode;
                    break;
            }
        }
        //=================================================================================================



        //=================================================================================================
        //  keyboard hook process
        //=================================================================================================
        private int KeyboardHookProc(int nCode, Int32 wParam, IntPtr lParam)
        {
            KeyboardHookStruct MyKeyboardHookStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));

            if(mouseDown == 0)
            {
                // key down process
                if (MyKeyboardHookStruct.vkCode == keyCode && (wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN))
                {
                    listener.keyDown(); // callback
                    if (blockOriginalInput) { return 1; }
                }
                // key up process
                else if (MyKeyboardHookStruct.vkCode == keyCode && (wParam == WM_KEYUP || wParam == WM_SYSKEYUP))
                {
                    listener.keyUp(); // callback
                    if (blockOriginalInput) { return 1; }
                }
            }

            return CallNextHookEx(hKeyboardHook, nCode, wParam, lParam);
        }
        //=================================================================================================



        //=================================================================================================
        //  conversion int 
        //=================================================================================================
        public static uint HIGHWORD(IntPtr ptr)
        {
            if (((uint)ptr & 0x80000000) == 0x80000000)
                return ((uint)ptr >> 16);
            else
                return ((uint)ptr >> 16) & 0xffff;
        }
        //=================================================================================================



        //=================================================================================================
        //  mouse hook process
        //=================================================================================================
        private int MouseHookProc(int nCode, int wParam, IntPtr lParam)
        {
            MSLLHOOKSTRUCT MyMouseHookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));

            if (keyCode == 0)
            {
                // key down process
                if (wParam == mouseDown && HIGHWORD((IntPtr)MyMouseHookStruct.mouseData) == xButton)
                {
                    listener.keyDown(); // callback
                    if (blockOriginalInput) { return 1; }
                }
                // key up process
                if (wParam == mouseUp && HIGHWORD((IntPtr)MyMouseHookStruct.mouseData) == xButton)
                {
                    listener.keyUp(); // callback
                    if (blockOriginalInput) { return 1; }
                }
            }

            return CallNextHookEx(hMouseHook, nCode, wParam, lParam);
        }
        //=================================================================================================



        //=================================================================================================
        //  hook start
        //=================================================================================================
        public void Start()
        {
            // if keyboard hook is not start
            if (hKeyboardHook == 0)
            {
                KeyboardHookProcedure = new HookProc(KeyboardHookProc);
                hKeyboardHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyboardHookProcedure, GetModuleHandle(System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName), 0);
                if (hKeyboardHook == 0)
                {
                    Stop();
                    throw new Exception("Keyboard Hook Error : Hook can't start");
                }
            }

            // if mouse hook is not start
            if (hMouseHook == 0)
            {
                MouseHookProcedure = new HookProc(MouseHookProc);
                hMouseHook = SetWindowsHookEx(WH_MOUSE_LL, MouseHookProcedure, GetModuleHandle(System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName), 0);

                if (hMouseHook == 0)
                {
                    Stop();
                    throw new Exception("Mouse Hook Error : Hook can't start");
                }
            }

        }
        //=================================================================================================



        //=================================================================================================
        //  hook stop
        //=================================================================================================
        public void Stop()
        {
            bool retKeyboard = true;
            bool retMouse = true;

            if (hKeyboardHook != 0)
            {
                retKeyboard = UnhookWindowsHookEx(hKeyboardHook);
                hKeyboardHook = 0;
            }

            if (hMouseHook != 0)
            {
                retMouse = UnhookWindowsHookEx(hMouseHook);
                hMouseHook = 0;
            }

            if (!(retKeyboard)) throw new Exception("Keyboard Hook Error : Hook can't stop");
            if (!(retMouse)) throw new Exception("Mouse Hook Error : Hook can't stop");
        }
        //=================================================================================================



        //=================================================================================================
        //  destructor
        //=================================================================================================
        ~KeyHook(){
            Stop();
        }
        //=================================================================================================

        //*************************************************************************************************
        //*************************************************************************************************


    }
}
