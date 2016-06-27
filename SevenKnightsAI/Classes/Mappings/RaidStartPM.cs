using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class RaidStartPM
	{
		
		public static readonly PixelMapping ManageParty1Border = new PixelMapping
		{
			X = 97,
			Y = 503,
			Color = 16574374,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping ManageParty1Button = new PixelMapping
		{
			X = 165,
			Y = 512,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping ManageParty2Border = new PixelMapping
		{
			X = 344,
			Y = 503,
			Color = 16639910,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping ManageParty2Button = new PixelMapping
		{
			X = 412,
			Y = 512,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping StartButton = new PixelMapping
		{
			X = 740,
			Y = 500,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping StartButtonBorder = new PixelMapping
		{
			X = 555,
			Y = 475,
			Color = 16047264,
			Type = MappingType.ANCHOR
		};
	}
}
