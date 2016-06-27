using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class OutOfLuckyBoxPopupPM
	{
		
		public static readonly PixelMapping BuyButton = new PixelMapping
		{
			X = 580,
			Y = 420,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping DimmedBG = new PixelMapping
		{
			X = 885,
			Y = 18,
			Color = 4930058,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping LuckyBoxIcon = new PixelMapping
		{
			X = 484,
			Y = 196,
			Color = 16144763,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping NoButton = new PixelMapping
		{
			X = 382,
			Y = 420,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping PopupBorder = new PixelMapping
		{
			X = 259,
			Y = 185,
			Color = 16772008,
			Type = MappingType.ANCHOR
		};
	}
}
