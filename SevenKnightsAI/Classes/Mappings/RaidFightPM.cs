using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class RaidFightPM
	{
		
		public static readonly PixelMapping DragonIcon = new PixelMapping
		{
			X = 104,
			Y = 59,
			Color = 16777214,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping SkipButton = new PixelMapping
		{
			X = 212,
			Y = 496,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping SkipOff = new PixelMapping
		{
			X = 212,
			Y = 524,
			Color = 7033650,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping SkipOn = new PixelMapping
		{
			X = 212,
			Y = 524,
			Color = 7481868,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping TeamTransition_1 = new PixelMapping
		{
			X = 706,
			Y = 15,
			Color = 7625021,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping TeamTransition_2 = new PixelMapping
		{
			X = 610,
			Y = 152,
			Color = 11043157,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping TeamTransition_3 = new PixelMapping
		{
			X = 111,
			Y = 215,
			Color = 6708057,
			Type = MappingType.ANCHOR
		};
	}
}
