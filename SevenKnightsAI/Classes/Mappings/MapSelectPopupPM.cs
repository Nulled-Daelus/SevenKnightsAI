using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class MapSelectPopupPM
	{
		
		public static readonly PixelMapping DimmedBG = new PixelMapping
		{
			X = 150,
			Y = 499,
			Color = 1182214,
			Type = MappingType.ANCHOR
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
			X = 698,
			Y = 198,
			Color = 16244898,
			Type = MappingType.ANCHOR
		};
	}
}
