using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class NoticePM
	{
		
		public static readonly PixelMapping CloseButton = new PixelMapping
		{
			X = 940,
			Y = 18,
			Color = 4997165,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping TopBorderLeft = new PixelMapping
		{
			X = 296,
			Y = 18,
			Color = 16701202,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping TopBorderRight = new PixelMapping
		{
			X = 616,
			Y = 18,
			Color = 16701202,
			Type = MappingType.ANCHOR
		};
	}
}
