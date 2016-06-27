using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class AndroidPopupPM
	{
		
		public static readonly PixelMapping BottomLeftBorder = new PixelMapping
		{
			X = 189,
			Y = 315,
			Color = 16119285,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping BottomRightBorder = new PixelMapping
		{
			X = 770,
			Y = 315,
			Color = 16119285,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping OkButton = new PixelMapping
		{
			X = 480,
			Y = 310,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping TopLeftBorder = new PixelMapping
		{
			X = 189,
			Y = 220,
			Color = 16119285,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping TopRightBorder = new PixelMapping
		{
			X = 770,
			Y = 220,
			Color = 16119285,
			Type = MappingType.ANCHOR
		};
	}
}
