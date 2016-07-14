using System;
using System.Runtime.InteropServices;

namespace SevenKnightsAI.Classes
{
    internal class User32
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref User32.Rect rect);

        public struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }
    }
}