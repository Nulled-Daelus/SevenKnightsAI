using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class RaidAlreadyEndedPopupPM
	{
		
		public static readonly PixelMapping DimmedBG = new PixelMapping
		{
			X = 460,
			Y = 494,
			Color = 1248006,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping PopupBorder = new PixelMapping
		{
			X = 260,
			Y = 205,
			Color = 16772008,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping TapArea = new PixelMapping
		{
			X = 480,
			Y = 400,
			Color = 0,
			Type = MappingType.BUTTON
		};
	}
}
