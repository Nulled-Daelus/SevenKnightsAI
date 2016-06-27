using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace SevenKnightsAI.Classes.Extensions
{
	
	public static class BitmapExtensions
	{
		
		public static Bitmap ScaleByPercent(this Bitmap imgPhoto, int Percent)
		{
			float num = (float)Percent / 100f;
			int width = imgPhoto.Width;
			int height = imgPhoto.Height;
			int width2 = (int)((float)width * num);
			int height2 = (int)((float)height * num);
			Bitmap bitmap = new Bitmap(width2, height2, PixelFormat.Format24bppRgb);
			bitmap.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics.DrawImage(imgPhoto, new Rectangle(0, 0, width2, height2), new Rectangle(0, 0, width, height), GraphicsUnit.Pixel);
			graphics.Dispose();
			return bitmap;
		}
	}
}
