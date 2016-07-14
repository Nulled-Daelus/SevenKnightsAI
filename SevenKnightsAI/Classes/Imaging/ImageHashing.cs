using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace SevenKnightsAI.Classes.Imaging
{
    public class ImageHashing
    {
        public static ulong AverageHash(Image image)
        {
            Bitmap bitmap = new Bitmap(8, 8, PixelFormat.Format32bppRgb);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.DrawImage(image, 0, 0, 8, 8);
            byte[] array = new byte[64];
            uint num = 0u;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    uint num2 = (uint)bitmap.GetPixel(j, i).ToArgb();
                    uint num3 = (num2 & 16711680u) >> 16;
                    num3 += (num2 & 65280u) >> 8;
                    num3 += (num2 & 255u);
                    num3 /= 12u;
                    array[j + i * 8] = (byte)num3;
                    num += num3;
                }
            }
            num /= 64u;
            ulong num4 = 0uL;
            for (int k = 0; k < 64; k++)
            {
                if ((uint)array[k] >= num)
                {
                    num4 |= 1uL << 63 - k;
                }
            }
            return num4;
        }

        public static ulong AverageHash(string path)
        {
            Bitmap image = new Bitmap(path);
            return ImageHashing.AverageHash(image);
        }

        private static uint BitCount(ulong num)
        {
            uint num2 = 0u;
            while (num > 0uL)
            {
                num2 += (uint)ImageHashing.bitCounts[(int)(checked((IntPtr)(num & 255uL)))];
                num >>= 8;
            }
            return num2;
        }

        public static double Similarity(ulong hash1, ulong hash2)
        {
            return (64u - ImageHashing.BitCount(hash1 ^ hash2)) * 100u / 64.0;
        }

        public static double Similarity(Image image1, Image image2)
        {
            ulong hash = ImageHashing.AverageHash(image1);
            ulong hash2 = ImageHashing.AverageHash(image2);
            return ImageHashing.Similarity(hash, hash2);
        }

        public static double Similarity(string path1, string path2)
        {
            ulong hash = ImageHashing.AverageHash(path1);
            ulong hash2 = ImageHashing.AverageHash(path2);
            return ImageHashing.Similarity(hash, hash2);
        }

        private static byte[] bitCounts = new byte[]
        {
            0,
            1,
            1,
            2,
            1,
            2,
            2,
            3,
            1,
            2,
            2,
            3,
            2,
            3,
            3,
            4,
            1,
            2,
            2,
            3,
            2,
            3,
            3,
            4,
            2,
            3,
            3,
            4,
            3,
            4,
            4,
            5,
            1,
            2,
            2,
            3,
            2,
            3,
            3,
            4,
            2,
            3,
            3,
            4,
            3,
            4,
            4,
            5,
            2,
            3,
            3,
            4,
            3,
            4,
            4,
            5,
            3,
            4,
            4,
            5,
            4,
            5,
            5,
            6,
            1,
            2,
            2,
            3,
            2,
            3,
            3,
            4,
            2,
            3,
            3,
            4,
            3,
            4,
            4,
            5,
            2,
            3,
            3,
            4,
            3,
            4,
            4,
            5,
            3,
            4,
            4,
            5,
            4,
            5,
            5,
            6,
            2,
            3,
            3,
            4,
            3,
            4,
            4,
            5,
            3,
            4,
            4,
            5,
            4,
            5,
            5,
            6,
            3,
            4,
            4,
            5,
            4,
            5,
            5,
            6,
            4,
            5,
            5,
            6,
            5,
            6,
            6,
            7,
            1,
            2,
            2,
            3,
            2,
            3,
            3,
            4,
            2,
            3,
            3,
            4,
            3,
            4,
            4,
            5,
            2,
            3,
            3,
            4,
            3,
            4,
            4,
            5,
            3,
            4,
            4,
            5,
            4,
            5,
            5,
            6,
            2,
            3,
            3,
            4,
            3,
            4,
            4,
            5,
            3,
            4,
            4,
            5,
            4,
            5,
            5,
            6,
            3,
            4,
            4,
            5,
            4,
            5,
            5,
            6,
            4,
            5,
            5,
            6,
            5,
            6,
            6,
            7,
            2,
            3,
            3,
            4,
            3,
            4,
            4,
            5,
            3,
            4,
            4,
            5,
            4,
            5,
            5,
            6,
            3,
            4,
            4,
            5,
            4,
            5,
            5,
            6,
            4,
            5,
            5,
            6,
            5,
            6,
            6,
            7,
            3,
            4,
            4,
            5,
            4,
            5,
            5,
            6,
            4,
            5,
            5,
            6,
            5,
            6,
            6,
            7,
            4,
            5,
            5,
            6,
            5,
            6,
            6,
            7,
            5,
            6,
            6,
            7,
            6,
            7,
            7,
            8
        };
    }
}