using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SerialPortTest
{
    public class VirtualInput
    {
        // Reference :　Nonsoft
        // http://homepage2.nifty.com/nonnon/SoftSample/CS.NET/SampleSendInput.html
        // マウスイベント(mouse_eventの引数と同様のデータ)
        [StructLayout(LayoutKind.Sequential)]
        private struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public int dwExtraInfo;
        };

        // キーボードイベント(keybd_eventの引数と同様のデータ)
        [StructLayout(LayoutKind.Sequential)]
        private struct KEYBDINPUT
        {
            public short wVk;
            public short wScan;
            public int dwFlags;
            public int time;
            public int dwExtraInfo;
        };

        // ハードウェアイベント
        [StructLayout(LayoutKind.Sequential)]
        private struct HARDWAREINPUT
        {
            public int uMsg;
            public short wParamL;
            public short wParamH;
        };

        // 各種イベント(SendInputの引数データ)
        [StructLayout(LayoutKind.Explicit)]
        private struct INPUT
        {
            [FieldOffset(0)]
            public int type;
            [FieldOffset(4)]
            public MOUSEINPUT mi;
            [FieldOffset(4)]
            public KEYBDINPUT ki;
            [FieldOffset(4)]
            public HARDWAREINPUT hi;
        };

        // キー操作、マウス操作をシミュレート(擬似的に操作する)
        [DllImport("user32.dll")]
        private extern static void SendInput(
            int nInputs, ref INPUT pInputs, int cbsize);

        // 仮想キーコードをスキャンコードに変換
        [DllImport("user32.dll", EntryPoint = "MapVirtualKeyA")]
        private extern static int MapVirtualKey(
            int wCode, int wMapType);

        private const int INPUT_MOUSE = 0;                  // マウスイベント
        private const int INPUT_KEYBOARD = 1;               // キーボードイベント
        private const int INPUT_HARDWARE = 2;               // ハードウェアイベント

        private const int MOUSEEVENTF_MOVE = 0x1;           // マウスを移動する
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;    // 絶対座標指定
        private const int MOUSEEVENTF_LEFTDOWN = 0x2;       // 左　ボタンを押す
        private const int MOUSEEVENTF_LEFTUP = 0x4;         // 左　ボタンを離す
        private const int MOUSEEVENTF_RIGHTDOWN = 0x8;      // 右　ボタンを押す
        private const int MOUSEEVENTF_RIGHTUP = 0x10;       // 右　ボタンを離す
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x20;    // 中央ボタンを押す
        private const int MOUSEEVENTF_MIDDLEUP = 0x40;      // 中央ボタンを離す
        private const int MOUSEEVENTF_WHEEL = 0x800;        // ホイールを回転する
        private const int WHEEL_DELTA = 120;                // ホイール回転値

        private const int KEYEVENTF_KEYDOWN = 0x0;          // キーを押す
        private const int KEYEVENTF_KEYUP = 0x2;            // キーを離す
        private const int KEYEVENTF_EXTENDEDKEY = 0x1;      // 拡張コード
        private const int VK_SHIFT = 0x10;                  // SHIFTキー
        private const int VK_CTRL = 0x11;                   // CTRLキー
        private const int VK_ALT = 0x12;                    // ALTキー

        public VirtualInput()
        {

        }

        public void testMethod()
        {
            // キーボード操作実行用のデータ
            const int num = 4;
            INPUT[] inp = new INPUT[num];

            // (1)キーボード(SHIFT)を押す
            inp[0].type = INPUT_KEYBOARD;
            inp[0].ki.wVk = VK_SHIFT;
            inp[0].ki.wScan = (short)MapVirtualKey(inp[0].ki.wVk, 0);
            inp[0].ki.dwFlags = KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYDOWN;
            inp[0].ki.dwExtraInfo = 0;
            inp[0].ki.time = 0;

            // (2)キーボード(A)を押す
            inp[1].type = INPUT_KEYBOARD;
            inp[1].ki.wVk = (short)Keys.A;
            inp[1].ki.wScan = (short)MapVirtualKey(inp[1].ki.wVk, 0);
            inp[1].ki.dwFlags = KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYDOWN;
            inp[1].ki.dwExtraInfo = 0;
            inp[1].ki.time = 0;

            // (3)キーボード(A)を離す
            inp[2].type = INPUT_KEYBOARD;
            inp[2].ki.wVk = (short)Keys.A;
            inp[2].ki.wScan = (short)MapVirtualKey(inp[2].ki.wVk, 0);
            inp[2].ki.dwFlags = KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP;
            inp[2].ki.dwExtraInfo = 0;
            inp[2].ki.time = 0;

            // (4)キーボード(SHIFT)を離す
            inp[3].type = INPUT_KEYBOARD;
            inp[3].ki.wVk = VK_SHIFT;
            inp[3].ki.wScan = (short)MapVirtualKey(inp[3].ki.wVk, 0);
            inp[3].ki.dwFlags = KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP;
            inp[3].ki.dwExtraInfo = 0;
            inp[3].ki.time = 0;

            // キーボード操作実行
            SendInput(num, ref inp[0], Marshal.SizeOf(inp[0]));

            // 1000ミリ秒スリープ
            System.Threading.Thread.Sleep(1000);
        }

        public bool push2Keys(String command)
        {
            const int num = 4;
            INPUT[] inp = new INPUT[num];
            short decoration_key_val, alphabet_key_val;
            
            char[] sep = {'+'};
            String[] comm_split = command.ToLower().Split(sep);
            if (comm_split.Length != 2)
            {
                return false;
            }
            String decoration_key = comm_split[0];
            char ch = comm_split[1][0];
            if (!decoration_key.Equals("shift") && !decoration_key.Equals("ctrl") &&
                !decoration_key.Equals("alt"))
            {
                return false;
            }
            if (comm_split[1].Length != 1 ||
                !((ch >= 'a' && ch <= 'z') || (ch >= '0' && ch <= '9')))
            {
                return false;
            }

            if (decoration_key.Equals("shift"))
            {
                decoration_key_val = VK_SHIFT;
            }
            else if (decoration_key.Equals("ctrl"))
            {
                decoration_key_val = VK_CTRL;
            }
            else if (decoration_key.Equals("alt"))
            {
                decoration_key_val = VK_ALT;
            }
            else
            {
                return false;
            }

            switch (ch)
            {
                case 'a': alphabet_key_val = (short)Keys.A; break;
                case 'b': alphabet_key_val = (short)Keys.B; break;
                case 'c': alphabet_key_val = (short)Keys.C; break;
                case 'd': alphabet_key_val = (short)Keys.D; break;
                case 'e': alphabet_key_val = (short)Keys.E; break;
                case 'f': alphabet_key_val = (short)Keys.F; break;
                case 'g': alphabet_key_val = (short)Keys.G; break;
                case 'h': alphabet_key_val = (short)Keys.H; break;
                case 'i': alphabet_key_val = (short)Keys.I; break;
                case 'j': alphabet_key_val = (short)Keys.J; break;
                case 'k': alphabet_key_val = (short)Keys.K; break;
                case 'l': alphabet_key_val = (short)Keys.L; break;
                case 'm': alphabet_key_val = (short)Keys.M; break;
                case 'n': alphabet_key_val = (short)Keys.N; break;
                case 'o': alphabet_key_val = (short)Keys.O; break;
                case 'p': alphabet_key_val = (short)Keys.P; break;
                case 'q': alphabet_key_val = (short)Keys.Q; break;
                case 'r': alphabet_key_val = (short)Keys.R; break;
                case 's': alphabet_key_val = (short)Keys.S; break;
                case 't': alphabet_key_val = (short)Keys.T; break;
                case 'u': alphabet_key_val = (short)Keys.U; break;
                case 'v': alphabet_key_val = (short)Keys.V; break;
                case 'w': alphabet_key_val = (short)Keys.W; break;
                case 'x': alphabet_key_val = (short)Keys.X; break;
                case 'y': alphabet_key_val = (short)Keys.Y; break;
                case 'z': alphabet_key_val = (short)Keys.Z; break;
                case '0': alphabet_key_val = (short)Keys.D0; break;
                case '1': alphabet_key_val = (short)Keys.D1; break;
                case '2': alphabet_key_val = (short)Keys.D2; break;
                case '3': alphabet_key_val = (short)Keys.D3; break;
                case '4': alphabet_key_val = (short)Keys.D4; break;
                case '5': alphabet_key_val = (short)Keys.D5; break;
                case '6': alphabet_key_val = (short)Keys.D6; break;
                case '7': alphabet_key_val = (short)Keys.D7; break;
                case '8': alphabet_key_val = (short)Keys.D8; break;
                case '9': alphabet_key_val = (short)Keys.D9; break;
                default: return false;
            }

            // Push down decoration key.
            inp[0].type = INPUT_KEYBOARD;
            inp[0].ki.wVk = decoration_key_val;
            inp[0].ki.wScan = (short)MapVirtualKey(inp[0].ki.wVk, 0);
            inp[0].ki.dwFlags = KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYDOWN;
            inp[0].ki.dwExtraInfo = 0;
            inp[0].ki.time = 0;

            // Push down alphabet key.
            inp[1].type = INPUT_KEYBOARD;
            inp[1].ki.wVk = (short)alphabet_key_val;
            inp[1].ki.wScan = (short)MapVirtualKey(inp[1].ki.wVk, 0);
            inp[1].ki.dwFlags = KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYDOWN;
            inp[1].ki.dwExtraInfo = 0;
            inp[1].ki.time = 0;

            // Leave alphabet key.
            inp[2].type = INPUT_KEYBOARD;
            inp[2].ki.wVk = (short)alphabet_key_val;
            inp[2].ki.wScan = (short)MapVirtualKey(inp[2].ki.wVk, 0);
            inp[2].ki.dwFlags = KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP;
            inp[2].ki.dwExtraInfo = 0;
            inp[2].ki.time = 0;

            // Leave decoration key.
            inp[3].type = INPUT_KEYBOARD;
            inp[3].ki.wVk = decoration_key_val;
            inp[3].ki.wScan = (short)MapVirtualKey(inp[3].ki.wVk, 0);
            inp[3].ki.dwFlags = KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP;
            inp[3].ki.dwExtraInfo = 0;
            inp[3].ki.time = 0;

            // Execute.
            SendInput(num, ref inp[0], Marshal.SizeOf(inp[0]));

            // 100 msec sleep
            System.Threading.Thread.Sleep(100);

            return true;
        }

        public bool mouseLeftClick(int x, int y)
        {
            const int num = 3;
            INPUT[] inp = new INPUT[num];

            // Move mouse cursor.
            inp[0].type = INPUT_MOUSE;
            inp[0].mi.dwFlags = MOUSEEVENTF_MOVE | MOUSEEVENTF_ABSOLUTE;
            inp[0].mi.dx = x * (65535 / Screen.PrimaryScreen.Bounds.Width);
            inp[0].mi.dy = y * (65535 / Screen.PrimaryScreen.Bounds.Height);
            inp[0].mi.mouseData = 0;
            inp[0].mi.dwExtraInfo = 0;
            inp[0].mi.time = 0;

            // Push down left button.
            inp[1].type = INPUT_MOUSE;
            inp[1].mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            inp[1].mi.dx = 0;
            inp[1].mi.dy = 0;
            inp[1].mi.mouseData = 0;
            inp[1].mi.dwExtraInfo = 0;
            inp[1].mi.time = 0;

            // Leave left button.
            inp[2].type = INPUT_MOUSE;
            inp[2].mi.dwFlags = MOUSEEVENTF_LEFTUP;
            inp[2].mi.dx = 0;
            inp[2].mi.dy = 0;
            inp[2].mi.mouseData = 0;
            inp[2].mi.dwExtraInfo = 0;
            inp[2].mi.time = 0;

            // Execute.
            SendInput(num, ref inp[0], Marshal.SizeOf(inp[0]));

            // 100msec sleep.
            System.Threading.Thread.Sleep(100);

            return true;
        }
    }
}
