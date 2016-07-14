using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace SevenKnightsAI.Classes.Imaging
{
    public class LockBitmap
    {
        public LockBitmap(Bitmap source)
        {
            this.source = source;
        }

        public Color GetPixel(int x, int y)
        {
            Color result = Color.Empty;
            int num = this.Depth / 8;
            int num2 = (y * this.Width + x) * num;
            if (num2 > this.Pixels.Length - num)
            {
                throw new IndexOutOfRangeException();
            }
            if (this.Depth == 32)
            {
                byte blue = this.Pixels[num2];
                byte green = this.Pixels[num2 + 1];
                byte red = this.Pixels[num2 + 2];
                byte alpha = this.Pixels[num2 + 3];
                result = Color.FromArgb((int)alpha, (int)red, (int)green, (int)blue);
            }
            if (this.Depth == 24)
            {
                byte blue2 = this.Pixels[num2];
                byte green2 = this.Pixels[num2 + 1];
                byte red2 = this.Pixels[num2 + 2];
                result = Color.FromArgb((int)red2, (int)green2, (int)blue2);
            }
            if (this.Depth == 8)
            {
                byte b = this.Pixels[num2];
                result = Color.FromArgb((int)b, (int)b, (int)b);
            }
            return result;
        }

        public void LockBits()
        {
            try
            {
                this.Width = this.source.Width;
                this.Height = this.source.Height;
                int num = this.Width * this.Height;
                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
                this.Depth = Image.GetPixelFormatSize(this.source.PixelFormat);
                if (this.Depth != 8 && this.Depth != 24 && this.Depth != 32)
                {
                    throw new ArgumentException("Only 8, 24 and 32 bpp images are supported.");
                }
                this.bitmapData = this.source.LockBits(rect, ImageLockMode.ReadWrite, this.source.PixelFormat);
                int num2 = this.Depth / 8;
                this.Pixels = new byte[num * num2];
                this.Iptr = this.bitmapData.Scan0;
                Marshal.Copy(this.Iptr, this.Pixels, 0, this.Pixels.Length);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SetPixel(int x, int y, Color color)
        {
            int num = this.Depth / 8;
            int num2 = (y * this.Width + x) * num;
            if (this.Depth == 32)
            {
                this.Pixels[num2] = color.B;
                this.Pixels[num2 + 1] = color.G;
                this.Pixels[num2 + 2] = color.R;
                this.Pixels[num2 + 3] = color.A;
            }
            if (this.Depth == 24)
            {
                this.Pixels[num2] = color.B;
                this.Pixels[num2 + 1] = color.G;
                this.Pixels[num2 + 2] = color.R;
            }
            if (this.Depth == 8)
            {
                this.Pixels[num2] = color.B;
            }
        }

        public void UnlockBits()
        {
            try
            {
                Marshal.Copy(this.Pixels, 0, this.Iptr, this.Pixels.Length);
                this.source.UnlockBits(this.bitmapData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Depth
        {
            get;

            private set;
        }

        public int Height
        {
            get;

            private set;
        }

        public byte[] Pixels;

        public int Width
        {
            get;

            private set;
        }

        private BitmapData bitmapData;

        private IntPtr Iptr = IntPtr.Zero;

        private Bitmap source;
    }
}