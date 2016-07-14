using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace SevenKnightsAI.Classes
{
    internal class ForegroundCapture
    {
        public static Bitmap CaptureWindow(IntPtr handle)
        {
            User32.Rect rect = default(User32.Rect);
            User32.GetWindowRect(handle, ref rect);
            int width = rect.right - rect.left;
            int height = rect.bottom - rect.top;
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
            return bitmap;
        }
    }
}