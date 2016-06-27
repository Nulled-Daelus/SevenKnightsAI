using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class ShopBuyPopupPM
	{
		
		public static readonly PixelMapping BuyButton = new PixelMapping
		{
			X = 650,
			Y = 422,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping NoButton = new PixelMapping
		{
			X = 385,
			Y = 418,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping PopupBorderLeft = new PixelMapping
		{
			X = 259,
			Y = 186,
            Color = 16772008,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping PopupBorderRight = new PixelMapping
		{
			X = 699,
			Y = 186,
            Color = 16772008,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping RedCross = new PixelMapping
		{
			X = 323,
			Y = 418,
            Color = 13712649,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping YellowTick = new PixelMapping
		{
			X = 519,
			Y = 423,
            Color = 16756754,
			Type = MappingType.ANCHOR
		};
	}
}
