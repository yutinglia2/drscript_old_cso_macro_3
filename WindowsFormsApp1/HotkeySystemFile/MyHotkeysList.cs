#region 組件 System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\System.Windows.Forms.dll
#endregion

using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.InteropServices;

namespace System.Windows.Forms
{
    //
    // 摘要:
    //     指定按鍵碼 (Key Code) 和修飾詞 (Modifier)。
    [ComVisible(true)]
    [Editor("System.Windows.Forms.Design.ShortcutKeysEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
    [Flags]
    [TypeConverter(typeof(KeysConverter))]
    public enum MyHotkeysList
    {
        //
        // 摘要:
        //     未按下任何鍵。
        None = 0,
        //
        // 摘要:
        //     滑鼠左鍵。
        滑鼠左鍵 = 1,
        //
        // 摘要:
        //     滑鼠右鍵。
        滑鼠右鍵 = 2,
        //
        // 摘要:
        //     CANCEL 鍵。
        Cancel = 3,
        //
        // 摘要:
        //     滑鼠中鍵 (三鍵式滑鼠)。
        滑鼠中鍵 = 4,
        //
        // 摘要:
        //     第一個 X 滑鼠鍵 (五鍵式滑鼠)。
        滑鼠側鍵1 = 5,
        //
        // 摘要:
        //     第二個 X 滑鼠鍵 (五鍵式滑鼠)。
        滑鼠側鍵2 = 6,
        //
        // 摘要:
        //     退格鍵。
        Back = 8,
        //
        // 摘要:
        //     TAB 鍵。
        Tab = 9,
        //
        // 摘要:
        //     RETURN 鍵。
        Return = 13,
        //
        // 摘要:
        //     ENTER 鍵。
        Enter = 13,
        //
        // 摘要:
        //     SHIFT 鍵。
        ShiftKey = 16,
        //
        // 摘要:
        //     CTRL 鍵。
        ControlKey_CTRL = 17,
        //
        // 摘要:
        //     ALT 鍵。
        Menu = 18,
        //
        // 摘要:
        //     CAPS LOCK 鍵。
        CapsLock = 20,
        //
        // 摘要:
        //     ESC 鍵。
        Escape = 27,
        //
        // 摘要:
        //     空格鍵。
        Space = 32,
        //
        // 摘要:
        //     PAGE UP 鍵。
        Prior = 33,
        //
        // 摘要:
        //     PAGE UP 鍵。
        PageUp = 33,
        //
        // 摘要:
        //     PAGE DOWN 鍵。
        Next = 34,
        //
        // 摘要:
        //     PAGE DOWN 鍵。
        PageDown = 34,
        //
        // 摘要:
        //     END 鍵。
        End = 35,
        //
        // 摘要:
        //     HOME 鍵。
        Home = 36,
        //
        // 摘要:
        //     向左鍵。
        Left = 37,
        //
        // 摘要:
        //     向上鍵。
        Up = 38,
        //
        // 摘要:
        //     向右鍵。
        Right = 39,
        //
        // 摘要:
        //     向下鍵。
        Down = 40,
        //
        // 摘要:
        //     PRINT SCREEN 鍵。
        PrintScreen = 44,
        //
        // 摘要:
        //     INS 鍵。
        Insert = 45,
        //
        // 摘要:
        //     DEL 鍵。
        Delete = 46,
        //
        // 摘要:
        //     0 鍵。
        D0 = 48,
        //
        // 摘要:
        //     1 鍵。
        D1 = 49,
        //
        // 摘要:
        //     2 鍵。
        D2 = 50,
        //
        // 摘要:
        //     3 鍵。
        D3 = 51,
        //
        // 摘要:
        //     4 鍵。
        D4 = 52,
        //
        // 摘要:
        //     5 鍵。
        D5 = 53,
        //
        // 摘要:
        //     6 鍵。
        D6 = 54,
        //
        // 摘要:
        //     7 鍵。
        D7 = 55,
        //
        // 摘要:
        //     8 鍵。
        D8 = 56,
        //
        // 摘要:
        //     9 鍵。
        D9 = 57,
        //
        // 摘要:
        //     A 鍵。
        A = 65,
        //
        // 摘要:
        //     B 鍵。
        B = 66,
        //
        // 摘要:
        //     C 鍵。
        C = 67,
        //
        // 摘要:
        //     D 鍵。
        D = 68,
        //
        // 摘要:
        //     E 鍵。
        E = 69,
        //
        // 摘要:
        //     F 鍵。
        F = 70,
        //
        // 摘要:
        //     G 鍵。
        G = 71,
        //
        // 摘要:
        //     H 鍵。
        H = 72,
        //
        // 摘要:
        //     I 鍵。
        I = 73,
        //
        // 摘要:
        //     J 鍵。
        J = 74,
        //
        // 摘要:
        //     K 鍵。
        K = 75,
        //
        // 摘要:
        //     L 鍵。
        L = 76,
        //
        // 摘要:
        //     M 鍵。
        M = 77,
        //
        // 摘要:
        //     N 鍵。
        N = 78,
        //
        // 摘要:
        //     O 鍵。
        O = 79,
        //
        // 摘要:
        //     P 鍵。
        P = 80,
        //
        // 摘要:
        //     Q 鍵。
        Q = 81,
        //
        // 摘要:
        //     R 鍵。
        R = 82,
        //
        // 摘要:
        //     S 鍵。
        S = 83,
        //
        // 摘要:
        //     T 鍵。
        T = 84,
        //
        // 摘要:
        //     U 鍵。
        U = 85,
        //
        // 摘要:
        //     V 鍵。
        V = 86,
        //
        // 摘要:
        //     W 鍵。
        W = 87,
        //
        // 摘要:
        //     X 鍵。
        X = 88,
        //
        // 摘要:
        //     Y 鍵。
        Y = 89,
        //
        // 摘要:
        //     Z 鍵。
        Z = 90,
        //
        // 摘要:
        //     左 Windows 標誌鍵 (Microsoft Natural Keyboard)。
        LWin = 91,
        //
        // 摘要:
        //     右 Windows 標誌鍵 (Microsoft Natural Keyboard)。
        RWin = 92,
        //
        // 摘要:
        //     數字鍵台上的 0 鍵。
        NumPad0 = 96,
        //
        // 摘要:
        //     數字鍵台上的 1 鍵。
        NumPad1 = 97,
        //
        // 摘要:
        //     數字鍵台上的 2 鍵。
        NumPad2 = 98,
        //
        // 摘要:
        //     數字鍵台上的 3 鍵。
        NumPad3 = 99,
        //
        // 摘要:
        //     數字鍵台上的 4 鍵。
        NumPad4 = 100,
        //
        // 摘要:
        //     數字鍵台上的 5 鍵。
        NumPad5 = 101,
        //
        // 摘要:
        //     數字鍵台上的 6 鍵。
        NumPad6 = 102,
        //
        // 摘要:
        //     數字鍵台上的 7 鍵。
        NumPad7 = 103,
        //
        // 摘要:
        //     數字鍵台上的 8 鍵。
        NumPad8 = 104,
        //
        // 摘要:
        //     數字鍵台上的 9 鍵。
        NumPad9 = 105,
        //
        // 摘要:
        //     Multiply 鍵。
        Multiply = 106,
        //
        // 摘要:
        //     加號鍵。
        Add = 107,
        //
        // 摘要:
        //     Separator 鍵。
        Separator = 108,
        //
        // 摘要:
        //     Subtract 鍵。
        Subtract = 109,
        //
        // 摘要:
        //     Decimal 鍵。
        Decimal = 110,
        //
        // 摘要:
        //     Divide 鍵。
        Divide = 111,
        //
        // 摘要:
        //     F1 鍵。
        F1 = 112,
        //
        // 摘要:
        //     F2 鍵。
        F2 = 113,
        //
        // 摘要:
        //     F3 鍵。
        F3 = 114,
        //
        // 摘要:
        //     F4 鍵。
        F4 = 115,
        //
        // 摘要:
        //     F5 鍵。
        F5 = 116,
        //
        // 摘要:
        //     F6 鍵。
        F6 = 117,
        //
        // 摘要:
        //     F7 鍵。
        F7 = 118,
        //
        // 摘要:
        //     F8 鍵。
        F8 = 119,
        //
        // 摘要:
        //     F9 鍵。
        F9 = 120,
        //
        // 摘要:
        //     F10 鍵。
        F10 = 121,
        //
        // 摘要:
        //     F11 鍵。
        F11 = 122,
        //
        // 摘要:
        //     F12 鍵。
        F12 = 123,
        //
        // 摘要:
        //     F13 鍵。
        F13 = 124,
        //
        // 摘要:
        //     F14 鍵。
        F14 = 125,
        //
        // 摘要:
        //     F15 鍵。
        F15 = 126,
        //
        // 摘要:
        //     F16 鍵。
        F16 = 127,
        //
        // 摘要:
        //     F17 鍵。
        F17 = 128,
        //
        // 摘要:
        //     F18 鍵。
        F18 = 129,
        //
        // 摘要:
        //     F19 鍵。
        F19 = 130,
        //
        // 摘要:
        //     F20 鍵。
        F20 = 131,
        //
        // 摘要:
        //     F21 鍵。
        F21 = 132,
        //
        // 摘要:
        //     F22 鍵。
        F22 = 133,
        //
        // 摘要:
        //     F23 鍵。
        F23 = 134,
        //
        // 摘要:
        //     F24 鍵。
        F24 = 135,
        //
        // 摘要:
        //     NUM LOCK 鍵。
        NumLock = 144,
        //
        // 摘要:
        //     SCROLL LOCK 鍵。
        Scroll = 145,
        //
        // 摘要:
        //     左 SHIFT 鍵。
        LShiftKey = 160,
        //
        // 摘要:
        //     右 SHIFT 鍵。
        RShiftKey = 161,
        //
        // 摘要:
        //     左 CTRL 鍵。
        LControlKey = 162,
        //
        // 摘要:
        //     右 CTRL 鍵。
        RControlKey = 163,
        //
        // 摘要:
        //     左 ALT 鍵。
        LMenu = 164,
        //
        // 摘要:
        //     右 ALT 鍵。
        RMenu = 165,
        //
        // 摘要:
        //     SHIFT 輔助按鍵。
        Shift = 65536,
        //
        // 摘要:
        //     CTRL 輔助按鍵。
        Control = 131072,
        //
        // 摘要:
        //     ALT 輔助按鍵 (Modifier Key)。
        Alt = 262144
    }
}