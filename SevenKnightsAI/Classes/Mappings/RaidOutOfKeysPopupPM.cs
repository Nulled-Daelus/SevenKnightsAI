using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class RaidOutOfKeysPopupPM
	{
		
		public static readonly PixelMapping BuyButton = new PixelMapping
		{
			X = 590,
			Y = 396,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping BuyIcon = new PixelMapping
		{
			X = 553,
			Y = 396,
			Color = 13999149,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping DimmedBG = new PixelMapping
		{
			X = 460,
			Y = 494,
			Color = 1248006,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping NoButton = new PixelMapping
		{
			X = 378,
			Y = 396,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping PopupBorder = new PixelMapping
		{
			X = 260,
			Y = 205,
			Color = 16772008,
			Type = MappingType.ANCHOR
		};
	}
}
