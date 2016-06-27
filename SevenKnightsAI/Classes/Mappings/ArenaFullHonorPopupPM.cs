using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class ArenaFullHonorPopupPM
	{
		
		public static readonly PixelMapping DimmedBG = new PixelMapping
		{
			X = 918,
			Y = 470,
			Color = 1182214,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping NoButton = new PixelMapping
		{
			X = 375,
			Y = 397,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping PopupBorderLeft = new PixelMapping
		{
			X = 259,
			Y = 198,
			Color = 16244898,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping PopupBorderRight = new PixelMapping
		{
			X = 699,
			Y = 198,
			Color = 16244898,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping YellowTick = new PixelMapping
		{
			X = 538,
			Y = 389,
			Color = 16775001,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping YesButton = new PixelMapping
		{
			X = 586,
			Y = 397,
			Color = 0,
			Type = MappingType.BUTTON
		};
	}
}
