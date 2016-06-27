using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class ArenaFightPM
	{
		
		public static readonly PixelMapping ChatButton = new PixelMapping
		{
			X = 933,
			Y = 30,
			Color = 13943163,
			Type = MappingType.BOTH
		};

		
		public static readonly PixelMapping PauseButton = new PixelMapping
		{
			X = 939,
			Y = 72,
			Color = 3546898,
			Type = MappingType.BOTH
		};

		
		public static readonly PixelMapping TimeBorder = new PixelMapping
		{
			X = 480,
			Y = 25,
			Color = 1706762,
			Type = MappingType.ANCHOR
		};
	}
}
