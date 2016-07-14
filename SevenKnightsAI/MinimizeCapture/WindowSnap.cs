using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MinimizeCapture
{
    public class WindowSnap
    {
        private WindowSnap(IntPtr hWnd, bool specialCapturing)
        {
            this.isIconic = WindowSnap.IsIconic(hWnd);
            this.hWnd = hWnd;
            if (specialCapturing)
            {
                WindowSnap.EnterSpecialCapturing(hWnd);
            }
            WindowSnap.WINDOWINFO wINDOWINFO = default(WindowSnap.WINDOWINFO);
            wINDOWINFO.cbSize = WindowSnap.WINDOWINFO.GetSize();
            WindowSnap.GetWindowInfo(hWnd, ref wINDOWINFO);
            bool flag = false;
            IntPtr parent = WindowSnap.GetParent(hWnd);
            Rectangle rectangle = default(Rectangle);
            Rectangle rectangle2 = default(Rectangle);
            if (WindowSnap.forceMDI && parent != IntPtr.Zero && (wINDOWINFO.dwExStyle & WindowSnap.ExtendedWindowStyles.WS_EX_MDICHILD) == WindowSnap.ExtendedWindowStyles.WS_EX_MDICHILD)
            {
                StringBuilder stringBuilder = new StringBuilder();
                WindowSnap.GetClassName(parent, stringBuilder, "RunDLL".Length + 1);
                if (stringBuilder.ToString() != "RunDLL")
                {
                    flag = true;
                    rectangle = WindowSnap.GetWindowPlacement(hWnd);
                    WindowSnap.MoveWindow(hWnd, 2147483647, 2147483647, rectangle.Width, rectangle.Height, true);
                    WindowSnap.SetParent(hWnd, IntPtr.Zero);
                    rectangle2 = WindowSnap.GetWindowPlacement(parent);
                }
            }
            Rectangle windowPlacement = WindowSnap.GetWindowPlacement(hWnd);
            this.size = windowPlacement.Size;
            this.location = windowPlacement.Location;
            this.text = WindowSnap.GetWindowText(hWnd);
            this.image = WindowSnap.GetWindowImage(hWnd, this.size);
            if (flag)
            {
                WindowSnap.SetParent(hWnd, parent);
                int num = wINDOWINFO.rcWindow.Left - rectangle2.X;
                int num2 = wINDOWINFO.rcWindow.Top - rectangle2.Y;
                if ((wINDOWINFO.dwStyle & WindowSnap.WindowStyles.WS_THICKFRAME) == WindowSnap.WindowStyles.WS_THICKFRAME)
                {
                    num -= SystemInformation.Border3DSize.Width;
                    num2 -= SystemInformation.Border3DSize.Height;
                }
                WindowSnap.MoveWindow(hWnd, num, num2, rectangle.Width, rectangle.Height, true);
            }
            if (specialCapturing)
            {
                WindowSnap.ExitSpecialCapturing(hWnd);
            }
        }

        private static void EnterSpecialCapturing(IntPtr hWnd)
        {
            if (XPAppearance.MinAnimate)
            {
                XPAppearance.MinAnimate = false;
                WindowSnap.minAnimateChanged = true;
            }
            WindowSnap.winLong = WindowSnap.GetWindowLong(hWnd, -20);
            WindowSnap.SetWindowLong(hWnd, -20, WindowSnap.winLong | 524288);
            WindowSnap.SetLayeredWindowAttributes(hWnd, 0, 1, 2);
            WindowSnap.ShowWindow(hWnd, WindowSnap.ShowWindowEnum.Restore);
            WindowSnap.SendMessage(hWnd, 15u, 0u, 0u);
            Thread.Sleep(100);
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool EnumWindows(WindowSnap.EnumWindowsCallbackHandler lpEnumFunc, IntPtr lParam);

        private static bool EnumWindowsCallback(IntPtr hWnd, IntPtr lParam)
        {
            bool specialCapturing = false;
            if (hWnd == IntPtr.Zero)
            {
                return false;
            }
            if (!WindowSnap.IsWindowVisible(hWnd))
            {
                return true;
            }
            if (!WindowSnap.countMinimizedWindows)
            {
                if (WindowSnap.IsIconic(hWnd))
                {
                    return true;
                }
            }
            else if (WindowSnap.IsIconic(hWnd) && WindowSnap.useSpecialCapturing)
            {
                specialCapturing = true;
            }
            if (WindowSnap.GetWindowText(hWnd) == "Program Manager")
            {
                return true;
            }
            WindowSnap.windowSnaps.Add(new WindowSnap(hWnd, specialCapturing));
            return true;
        }

        private static void ExitSpecialCapturing(IntPtr hWnd)
        {
            WindowSnap.ShowWindow(hWnd, WindowSnap.ShowWindowEnum.Minimize);
            WindowSnap.SetWindowLong(hWnd, -20, WindowSnap.winLong);
            if (WindowSnap.minAnimateChanged)
            {
                XPAppearance.MinAnimate = true;
                WindowSnap.minAnimateChanged = false;
            }
        }

        public static WindowSnapCollection GetAllWindows()
        {
            return WindowSnap.GetAllWindows(false, false);
        }

        public static WindowSnapCollection GetAllWindows(bool minimized, bool specialCapturring)
        {
            WindowSnap.windowSnaps = new WindowSnapCollection();
            WindowSnap.countMinimizedWindows = minimized;
            WindowSnap.useSpecialCapturing = specialCapturring;
            WindowSnap.EnumWindowsCallbackHandler lpEnumFunc = new WindowSnap.EnumWindowsCallbackHandler(WindowSnap.EnumWindowsCallback);
            WindowSnap.EnumWindows(lpEnumFunc, IntPtr.Zero);
            return new WindowSnapCollection(WindowSnap.windowSnaps.ToArray(), true);
        }

        [DllImport("user32")]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder name, int maxCount);

        [DllImport("user32")]
        private static extern IntPtr GetParent(IntPtr hWnd);

        private static Bitmap GetWindowImage(IntPtr hWnd, Size size)
        {
            Bitmap result;
            try
            {
                if (size.IsEmpty || size.Height < 0 || size.Width < 0)
                {
                    result = null;
                }
                else
                {
                    Bitmap bitmap = new Bitmap(size.Width, size.Height);
                    Graphics graphics = Graphics.FromImage(bitmap);
                    IntPtr hdc = graphics.GetHdc();
                    WindowSnap.PrintWindow(hWnd, hdc, 0u);
                    graphics.ReleaseHdc();
                    graphics.Dispose();
                    result = bitmap;
                }
            }
            catch
            {
                result = null;
            }
            return result;
        }

        [DllImport("user32.dll")]
        private static extern bool GetWindowInfo(IntPtr hwnd, ref WindowSnap.WINDOWINFO pwi);

        [DllImport("user32")]
        private static extern int GetWindowLong(IntPtr hWnd, int index);

        private static Rectangle GetWindowPlacement(IntPtr hWnd)
        {
            WindowSnap.RECT rect = default(WindowSnap.RECT);
            WindowSnap.GetWindowRect(hWnd, ref rect);
            return rect;
        }

        [DllImport("user32")]
        private static extern int GetWindowRect(IntPtr hWnd, ref WindowSnap.RECT rect);

        public static WindowSnap GetWindowSnap(IntPtr hWnd, bool useSpecialCapturing)
        {
            if (!useSpecialCapturing)
            {
                return new WindowSnap(hWnd, false);
            }
            return new WindowSnap(hWnd, WindowSnap.NeedSpecialCapturing(hWnd));
        }

        private static string GetWindowText(IntPtr hWnd)
        {
            int num = WindowSnap.GetWindowTextLength(hWnd) + 1;
            StringBuilder stringBuilder = new StringBuilder(num);
            WindowSnap.GetWindowText(hWnd, stringBuilder, num);
            return stringBuilder.ToString();
        }

        [DllImport("user32")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int maxCount);

        [DllImport("user32")]
        private static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsIconic(IntPtr hWnd);

        [DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool reDraw);

        private static bool NeedSpecialCapturing(IntPtr hWnd)
        {
            return WindowSnap.IsIconic(hWnd);
        }

        [DllImport("user32")]
        private static extern int PrintWindow(IntPtr hWnd, IntPtr dc, uint flags);

        [DllImport("user32.dll")]
        private static extern uint SendMessage(IntPtr hWnd, uint msg, uint wParam, uint lParam);

        [DllImport("user32")]
        private static extern int SetLayeredWindowAttributes(IntPtr hWnd, byte crey, byte alpha, int flags);

        [DllImport("user32")]
        private static extern IntPtr SetParent(IntPtr child, IntPtr newParent);

        [DllImport("user32")]
        private static extern int SetWindowLong(IntPtr hWnd, int index, int dwNewLong);

        [DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowWindow(IntPtr hWnd, WindowSnap.ShowWindowEnum flags);

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Window Text: {0}, Handle: {1}", this.text, this.hWnd.ToString());
            return stringBuilder.ToString();
        }

        public static bool ForceMDICapturing
        {
            get
            {
                return WindowSnap.forceMDI;
            }

            set
            {
                WindowSnap.forceMDI = value;
            }
        }

        public IntPtr Handle
        {
            get
            {
                return this.hWnd;
            }
        }

        public Bitmap Image
        {
            get
            {
                if (this.image != null)
                {
                    return this.image;
                }
                return null;
            }
        }

        public bool IsMinimized
        {
            get
            {
                return this.isIconic;
            }
        }

        public Point Location
        {
            get
            {
                return this.location;
            }
        }

        public Size Size
        {
            get
            {
                return this.size;
            }
        }

        public string Text
        {
            get
            {
                return this.text;
            }
        }

        [ThreadStatic]
        private static bool countMinimizedWindows;

        private static bool forceMDI = true;

        private const int GWL_EXSTYLE = -20;

        private IntPtr hWnd;

        private Bitmap image;

        private bool isIconic;

        private Point location;

        private const int LWA_ALPHA = 2;

        [ThreadStatic]
        private static bool minAnimateChanged = false;

        private const string PROGRAMMANAGER = "Program Manager";

        private const string RUNDLL = "RunDLL";

        private Size size;

        private string text;

        [ThreadStatic]
        private static bool useSpecialCapturing;

        [ThreadStatic]
        private static WindowSnapCollection windowSnaps;

        [ThreadStatic]
        private static int winLong;

        private const uint WM_PAINT = 15u;

        private const int WS_EX_LAYERED = 524288;

        private delegate bool EnumWindowsCallbackHandler(IntPtr hWnd, IntPtr lParam);

        [Flags]
        private enum ExtendedWindowStyles : uint
        {
            WS_EX_DLGMODALFRAME = 1u,

            WS_EX_NOPARENTNOTIFY = 4u,

            WS_EX_TOPMOST = 8u,

            WS_EX_ACCEPTFILES = 16u,

            WS_EX_TRANSPARENT = 32u,

            WS_EX_MDICHILD = 64u,

            WS_EX_TOOLWINDOW = 128u,

            WS_EX_WINDOWEDGE = 256u,

            WS_EX_CLIENTEDGE = 512u,

            WS_EX_CONTEXTHELP = 1024u,

            WS_EX_RIGHT = 4096u,

            WS_EX_LEFT = 0u,

            WS_EX_RTLREADING = 8192u,

            WS_EX_LTRREADING = 0u,

            WS_EX_LEFTSCROLLBAR = 16384u,

            WS_EX_RIGHTSCROLLBAR = 0u,

            WS_EX_CONTROLPARENT = 65536u,

            WS_EX_STATICEDGE = 131072u,

            WS_EX_APPWINDOW = 262144u,

            WS_EX_OVERLAPPEDWINDOW = 768u,

            WS_EX_PALETTEWINDOW = 392u
        }

        private struct RECT
        {
            public static implicit operator Rectangle(WindowSnap.RECT rect)
            {
                return new Rectangle(rect.left, rect.top, rect.Width, rect.Height);
            }

            public int Height
            {
                get
                {
                    return this.bottom - this.top;
                }
            }

            public int Left
            {
                get
                {
                    return this.left;
                }
            }

            public int Top
            {
                get
                {
                    return this.top;
                }
            }

            public int Width
            {
                get
                {
                    return this.right - this.left;
                }
            }

            private int left;

            private int top;

            private int right;

            private int bottom;
        }

        private enum ShowWindowEnum
        {
            Hide,

            ShowNormal,

            ShowMinimized,

            ShowMaximized,

            Maximize = 3,

            ShowNormalNoActivate,

            Show,

            Minimize,

            ShowMinNoActivate,

            ShowNoActivate,

            Restore,

            ShowDefault,

            ForceMinimized
        }

        private struct WINDOWINFO
        {
            public static uint GetSize()
            {
                return (uint)Marshal.SizeOf(typeof(WindowSnap.WINDOWINFO));
            }

            public uint cbSize;

            public WindowSnap.RECT rcWindow;

            public WindowSnap.RECT rcClient;

            public WindowSnap.WindowStyles dwStyle;

            public WindowSnap.ExtendedWindowStyles dwExStyle;

            public uint dwWindowStatus;

            public uint cxWindowBorders;

            public uint cyWindowBorders;

            public ushort atomWindowType;

            public ushort wCreatorVersion;
        }

        [Flags]
        private enum WindowStyles : uint
        {
            WS_OVERLAPPED = 0u,

            WS_POPUP = 2147483648u,

            WS_CHILD = 1073741824u,

            WS_MINIMIZE = 536870912u,

            WS_VISIBLE = 268435456u,

            WS_DISABLED = 134217728u,

            WS_CLIPSIBLINGS = 67108864u,

            WS_CLIPCHILDREN = 33554432u,

            WS_MAXIMIZE = 16777216u,

            WS_BORDER = 8388608u,

            WS_DLGFRAME = 4194304u,

            WS_VSCROLL = 2097152u,

            WS_HSCROLL = 1048576u,

            WS_SYSMENU = 524288u,

            WS_THICKFRAME = 262144u,

            WS_GROUP = 131072u,

            WS_TABSTOP = 65536u,

            WS_MINIMIZEBOX = 131072u,

            WS_MAXIMIZEBOX = 65536u,

            WS_CAPTION = 12582912u,

            WS_TILED = 0u,

            WS_ICONIC = 536870912u,

            WS_SIZEBOX = 262144u,

            WS_TILEDWINDOW = 13565952u,

            WS_OVERLAPPEDWINDOW = 13565952u,

            WS_POPUPWINDOW = 2156396544u,

            WS_CHILDWINDOW = 1073741824u
        }
    }
}