using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class LevelUpDialogPM
	{
		
		public static readonly PixelMapping CharacterEye = new PixelMapping
		{
			X = 163,
			Y = 118,
			Color = 15654860,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping DialogBorder = new PixelMapping
		{
			X = 902,
			Y = 322,
			Color = 10712884,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping OkButton = new PixelMapping
		{
			X = 892,
			Y = 482,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping YellowTick = new PixelMapping
		{
			X = 820,
			Y = 485,
			Color = 16761637,
			Type = MappingType.ANCHOR
		};
	}
}
