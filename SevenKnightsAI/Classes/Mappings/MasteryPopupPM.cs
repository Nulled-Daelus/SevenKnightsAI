using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class MasteryPopupPM
	{
		
		public static readonly PixelMapping CloseButton = new PixelMapping
		{
			X = 865,
			Y = 94,
			Color = 12925963,
			Type = MappingType.BOTH
		};

		
		public static readonly PixelMapping RedBackground = new PixelMapping
		{
			X = 452,
			Y = 480,
			Color = 5374720,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping Tab1 = new PixelMapping
		{
			X = 660,
			Y = 95,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping Tab2 = new PixelMapping
		{
			X = 728,
			Y = 95,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping Tab3 = new PixelMapping
		{
			X = 796,
			Y = 95,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping TitleBorder = new PixelMapping
		{
			X = 63,
			Y = 77,
			Color = 0,
			Type = MappingType.ANCHOR
		};
	}
}
