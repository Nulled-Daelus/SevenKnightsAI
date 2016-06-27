using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class QuestCollectFailedPopupPM
	{
		
		public static readonly PixelMapping DimmedBG_1 = new PixelMapping
		{
			X = 145,
			Y = 278,
			Color = 3157030,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping DimmedBG_2 = new PixelMapping
		{
			X = 84,
			Y = 368,
			Color = 4934474,
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
