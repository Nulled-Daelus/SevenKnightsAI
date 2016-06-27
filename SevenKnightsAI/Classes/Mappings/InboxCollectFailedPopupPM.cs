using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class InboxCollectFailedPopupPM
	{
		
		public static readonly PixelMapping DimmedBG_1 = new PixelMapping
		{
			X = 195,
			Y = 315,
			Color = 4934475,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping DimmedBG_2 = new PixelMapping
		{
			X = 189,
			Y = 522,
			Color = 4867394,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping PopupBorder = new PixelMapping
		{
			X = 260,
			Y = 200,
			Color = 16639654,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping TapArea = new PixelMapping
		{
			X = 480,
			Y = 396,
			Color = 0,
			Type = MappingType.BUTTON
		};
	}
}
