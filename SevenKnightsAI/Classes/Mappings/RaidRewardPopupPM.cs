using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class RaidRewardPopupPM
	{
		
		public static readonly PixelMapping DimmedBG = new PixelMapping
		{
			X = 830,
			Y = 438,
			Color = 4932865,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping OkButton = new PixelMapping
		{
			X = 482,
			Y = 398,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping OkButtonBorder = new PixelMapping
		{
			X = 396,
			Y = 385,
			Color = 16706216,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping PopupBorder = new PixelMapping
		{
			X = 260,
			Y = 195,
			Color = 15126678,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping YellowTick = new PixelMapping
		{
			X = 430,
			Y = 388,
			Color = 16774744,
			Type = MappingType.ANCHOR
		};
	}
}
