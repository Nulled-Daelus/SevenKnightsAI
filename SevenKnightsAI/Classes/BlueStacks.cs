using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace SevenKnightsAI.Classes
{
    internal class BlueStacks
    {
        private static readonly string PACKAGE_NAME = "com.netmarble.sknightsgb";

        private static readonly string ACTIVITY_NAME = BlueStacks.PACKAGE_NAME + "/com.netmarble.sknightsgb.MainActivity";

        public static readonly int ACTUAL_HEIGHT = 570;

        public static readonly int ACTUAL_WIDTH = 962;

        public static readonly int BS_HEIGHT = 540;

        public static readonly int BS_WIDTH = 960;

        private static readonly string CONTROL_HANDLE_TITLE = "BlueStacks Android Plugin";

        public static readonly int GUEST_HEIGHT = 900;

        public static readonly int GUEST_WIDTH = 1600;

        private static readonly string HANDLE_TITLE = "Bluestacks App Player";

        public static readonly int OFFSET_X = 1;

        public static readonly int OFFSET_Y = 29;

        private static readonly string SETTINGS_HANDLE_TITLE = "WindowsForms10.Window.8.app.0.33c0d9d5";

        private static readonly string SIDE_MENU_HANDLE_TITLE = "WindowsForms10.Window.8.app.0.33c0d9d";

        private string Adb(string command)
        {
            this.ConnectAdb();
            string str = string.Format("-s localhost:{0} ", this.AdbPort);
            Process process = this.CreateProcess(this.AdbPath, str + command);
            process.Start();
            process.WaitForExit();
            return process.StandardOutput.ReadToEnd();
        }

        public Bitmap CaptureFrame(bool backgroundMode)
        {
            return this.MainWindowAS.CaptureFrame(backgroundMode, true);
        }

        private string ConnectAdb()
        {
            string arguments = string.Format("connect localhost:{0} ", this.AdbPort);
            Process process = this.CreateProcess(this.AdbPath, arguments);
            process.Start();
            process.WaitForExit();
            return process.StandardOutput.ReadToEnd();
        }

        private Process CreateProcess(string path, string arguments = null)
        {
            return new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = path,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
        }

        public string GetExePath()
        {
            uint num = 0u;
            BlueStacks.GetWindowThreadProcessId(this.MainWindowAS.Handle, out num);
            if (num == 0u)
            {
                return null;
            }
            Process processById = Process.GetProcessById((int)num);
            return processById.MainModule.FileName;
        }

        public Point GetMousePos()
        {
            Point mousePos = this.MainWindowAS.GetMousePos();
            return mousePos;
        }

        public int GetPixel(Point pos)
        {
            return GetPixel(pos.X, pos.Y);
        }

        public int GetPixel(int x, int y)
        {
            int result;
            try
            {
                result = this.MainWindowAS.GetPixel(x + BlueStacks.OFFSET_X, y + BlueStacks.OFFSET_Y);
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        public void Hide(bool useOpacity = true)
        {
            this.HideMainWindow(useOpacity);
            Thread.Sleep(50);
            this.HideSideMenu(useOpacity);
            this.IsHidden = true;
        }

        public void HideMainWindow(bool useOpacity = true)
        {
            if (useOpacity)
            {
                this.MainWindowOpacity(0);
                return;
            }
            this.MainWindowAS.Hide();
        }

        public void HideSideMenu(bool useOpacity = true)
        {
            if (useOpacity)
            {
                this.SideMenuOpacity(0);
                return;
            }
            this.SideMenuAS.Hide();
        }

        public bool Hook()
        {
            bool result;
            try
            {
                this.MainWindowAS = new AutoSpy(AutoSpy.GetHandle(BlueStacks.HANDLE_TITLE, null), AutoSpy.GetControlHandle(BlueStacks.HANDLE_TITLE, BlueStacks.CONTROL_HANDLE_TITLE));
                this.SideMenuAS = new AutoSpy(AutoSpy.GetHandle("", BlueStacks.SIDE_MENU_HANDLE_TITLE));
                this.Show(true);
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool IsGameActive()
        {
            return this.Adb("shell dumpsys window windows | grep mCurrentFocus").Contains(BlueStacks.ACTIVITY_NAME);
        }

        public bool IsGameInstalled()
        {
            return this.Adb("shell pm list packages " + BlueStacks.PACKAGE_NAME).Contains(BlueStacks.PACKAGE_NAME);
        }

        public void Kill()
        {
            Process process = this.CreateProcess(this.InstallPath + "HD-Quit.exe", null);
            process.Start();
            process.WaitForExit();
        }

        public void LaunchGame()
        {
            this.Adb("shell am start -n " + BlueStacks.ACTIVITY_NAME);
        }

        public void MainWindowOpacity(int value)
        {
            this.MainWindowAS.Opacity(value);
        }

        public bool NeedRenderConfig()
        {
            int num = (int)this.ConfigRegistryKey.GetValue("GlMode");
            int num2 = (int)this.ConfigRegistryKey.GetValue("GlRenderMode");
            return num != 1 || num2 != 2;
        }

        public bool NeedResize()
        {
            Size windowSize = this.WindowSize;
            Size guestSize = this.GuestSize;
            return windowSize.Width != BlueStacks.BS_WIDTH || windowSize.Height != BlueStacks.BS_HEIGHT || guestSize.Width != BlueStacks.GUEST_WIDTH || guestSize.Height != BlueStacks.GUEST_HEIGHT;
        }

        public void Opacity(int value)
        {
            this.MainWindowOpacity(value);
            this.SideMenuAS.Opacity(value);
        }

        public void RenderConfig()
        {
            this.ConfigRegistryKey.SetValue("GlMode", 1);
            this.ConfigRegistryKey.SetValue("GlRenderMode", 2);
        }

        public void Resize()
        {
            this.MainWindowAS.ResizeWindow(BlueStacks.ACTUAL_WIDTH, BlueStacks.ACTUAL_HEIGHT, true);
            this.FrameBufferRegistry.SetValue("WindowWidth", BlueStacks.BS_WIDTH);
            this.FrameBufferRegistry.SetValue("WindowHeight", BlueStacks.BS_HEIGHT);
            this.FrameBufferRegistry.SetValue("GuestWidth", BlueStacks.GUEST_WIDTH);
            this.FrameBufferRegistry.SetValue("GuestHeight", BlueStacks.GUEST_HEIGHT);
        }

        public bool RestartAndroid()
        {
            try
            {
                AutoSpy autoSpy = new AutoSpy(AutoSpy.GetHandle(BlueStacks.HANDLE_TITLE, null), AutoSpy.GetControlHandle(BlueStacks.HANDLE_TITLE, BlueStacks.SETTINGS_HANDLE_TITLE));
                autoSpy.FocusWindow();
                autoSpy.Click(16, 9, 1, 0, "left");
                autoSpy.PressKey(40u, 2, 100);
                autoSpy.PressKey(13u, 1, 100);
            }
            catch (Exception)
            {
                return false;
            }
            return this.Hook();
        }

        public bool RestartGame(int maxAttempts = 5)
        {
            this.TerminateGame();
            Thread.Sleep(200);
            this.LaunchGame();
            Thread.Sleep(2000);
            int i = 0;
            while (i <= maxAttempts)
            {
                bool flag = this.IsGameActive();
                if (flag)
                {
                    return true;
                }
                i++;
                Thread.Sleep(800);
                this.LaunchGame();
            }
            return false;
        }

        public void Show(bool useOpacity = true)
        {
            this.ShowMainWindow(useOpacity);
            Thread.Sleep(50);
            this.ShowSideMenu(useOpacity);
            this.IsHidden = false;
        }

        public void ShowMainWindow(bool useOpacity = true)
        {
            if (useOpacity)
            {
                this.MainWindowOpacity(-1);
                return;
            }
            this.MainWindowAS.Show();
        }

        public void ShowSideMenu(bool useOpacity = true)
        {
            if (useOpacity)
            {
                this.SideMenuOpacity(-1);
                return;
            }
            this.MainWindowAS.Show();
        }

        public void SideMenuOpacity(int value)
        {
            this.SideMenuAS.Opacity(value);
        }

        public void TerminateGame()
        {
            this.Adb("shell am force-stop " + BlueStacks.PACKAGE_NAME);
        }

        private string AdbPath
        {
            get
            {
                return this.InstallPath + "HD-Adb.exe";
            }
        }

        private string AdbPort
        {
            get
            {
                return this.ConfigRegistryKey.GetValue("bstadbport").ToString();
            }
        }

        private RegistryKey ConfigRegistryKey
        {
            get
            {
                return this.RegistryKey.OpenSubKey("Guests\\Android\\Config", true);
            }
        }

        private RegistryKey FrameBufferRegistry
        {
            get
            {
                return this.RegistryKey.OpenSubKey("Guests\\Android\\FrameBuffer\\0", true);
            }
        }

        public Size GuestSize
        {
            get
            {
                int width = (int)this.FrameBufferRegistry.GetValue("GuestWidth");
                int height = (int)this.FrameBufferRegistry.GetValue("GuestHeight");
                return new Size(width, height);
            }
        }

        private string InstallPath
        {
            get
            {
                return this.RegistryKey.GetValue("InstallDir") as string;
            }
        }

        public bool IsHidden
        {
            get;

            private set;
        }

        public AutoSpy MainWindowAS
        {
            get;

            private set;
        }

        private RegistryKey RegistryKey
        {
            get
            {
                return Registry.LocalMachine.OpenSubKey("Software\\BlueStacks", true);
            }
        }

        public AutoSpy SideMenuAS
        {
            get;

            private set;
        }

        public Size WindowSize
        {
            get
            {
                int width = (int)this.FrameBufferRegistry.GetValue("WindowWidth");
                int height = (int)this.FrameBufferRegistry.GetValue("WindowHeight");
                return new Size(width, height);
            }
        }
    }
}