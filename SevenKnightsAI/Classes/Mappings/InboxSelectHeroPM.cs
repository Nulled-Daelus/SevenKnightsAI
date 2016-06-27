using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class InboxSelectHeroPM
	{
		
		public static readonly PixelMapping Background = new PixelMapping
		{
			X = 296,
			Y = 476,
			Color = 5112320,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping SelectButton = new PixelMapping
		{
			X = 168,
			Y = 512,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping SelectButtonBorder = new PixelMapping
		{
			X = 300,
			Y = 497,
			Color = 16771752,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping SelectedBorder = new PixelMapping
		{
			X = 170,
			Y = 66,
			Color = 1708300,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping TitleBorder = new PixelMapping
		{
			X = 915,
			Y = 107,
			Color = 3086862,
			Type = MappingType.ANCHOR
		};
	}
}
