using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class LoginPM
	{
		
		public static readonly PixelMapping EmailButton = new PixelMapping
		{
			X = 740,
			Y = 605,
			Color = 14425640,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping FBButton = new PixelMapping
		{
			X = 490,
			Y = 600,
			Color = 3889560,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping PlayButtonLeft = new PixelMapping
		{
			X = 420,
			Y = 525,
			Color = 16696320,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping PlayButtonRight = new PixelMapping
		{
			X = 860,
			Y = 525,
			Color = 16696320,
			Type = MappingType.ANCHOR
		};
	}
}
