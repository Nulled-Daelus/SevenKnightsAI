using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class TowerSelectPM
	{
		
		public static readonly PixelMapping GoldChamberButton = new PixelMapping
		{
			X = 378,
			Y = 120,
			Color = 14467088,
			Type = MappingType.BOTH
		};

		
		public static readonly PixelMapping PreviewBorderLeft = new PixelMapping
		{
			X = 322,
			Y = 294,
			Color = 16772008,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping PreviewBorderRight = new PixelMapping
		{
			X = 922,
			Y = 294,
			Color = 16772008,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping ReadyButton = new PixelMapping
		{
			X = 740,
			Y = 490,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping ReadyDisabled = new PixelMapping
		{
			X = 580,
			Y = 468,
			Color = 1970442,
			Type = MappingType.ANCHOR
		};
	}
}
