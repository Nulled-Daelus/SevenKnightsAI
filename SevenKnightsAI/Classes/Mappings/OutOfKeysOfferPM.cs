using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class OutOfKeysOfferPM
	{
		
		public static readonly PixelMapping BuyButton = new PixelMapping
		{
			X = 620,
			Y = 456,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping BuyButtonBorder = new PixelMapping
		{
			X = 708,
			Y = 449,
			Color = 16771496,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping DimmedBG = new PixelMapping
		{
			X = 664,
			Y = 28,
			Color = 3747867,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping NoButton = new PixelMapping
		{
			X = 345,
			Y = 456,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping RedCross = new PixelMapping
		{
			X = 292,
			Y = 456,
			Color = 13843721,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping SkipTodayButton = new PixelMapping
		{
			X = 715,
			Y = 408,
			Color = 0,
			Type = MappingType.BUTTON
		};
	}
}
