using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class VictoryPM
	{
		
		public static readonly PixelMapping RibbonLeft = new PixelMapping
		{
			X = 345,
			Y = 32,
			Color = 16731648,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping RibbonMiddle = new PixelMapping
		{
			X = 570,
			Y = 71,
			Color = 16747022,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping RibbonRight = new PixelMapping
		{
			X = 614,
			Y = 32,
			Color = 16731648,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping TapToSkipArea = new PixelMapping
		{
			X = 480,
			Y = 322,
			Color = 0,
			Type = MappingType.BUTTON
		};
	}
}
