using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class SpecialQuestPM
	{
		
		public static readonly PixelMapping CollectButton = new PixelMapping
		{
			X = 864,
			Y = 232,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping CollectButtonBackground = new PixelMapping
		{
			X = 864,
			Y = 243,
			Color = 16770306,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping CollectMainButton = new PixelMapping
		{
			X = 864,
			Y = 137,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping CollectMainButtonBackground = new PixelMapping
		{
			X = 864,
			Y = 150,
			Color = 16770306,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping DailyAvailable = new PixelMapping
		{
			X = 324,
			Y = 74,
			Color = 13051648,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping DailyTab = new PixelMapping
		{
			X = 430,
			Y = 92,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly int GOLD_OFFSET_X = 277;

		
		public static readonly int GOLD_OFFSET_Y = 0;

		
		public static readonly int HONOR_OFFSET_X = 279;

		
		public static readonly int HONOR_OFFSET_Y = 0;

		
		public static readonly int KEY_OFFSET_X = 274;

		
		public static readonly int KEY_OFFSET_Y = 0;

		
		public static readonly PixelMapping MonthlyAvailable = new PixelMapping
		{
			X = 753,
			Y = 74,
			Color = 13051648,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping MonthlyTab = new PixelMapping
		{
			X = 850,
			Y = 92,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly int RUBY_OFFSET_X = 276;

		
		public static readonly int RUBY_OFFSET_Y = 0;

		
		public static readonly PixelMapping StatusBorder = new PixelMapping
		{
			X = 330,
			Y = 157,
			Color = 3086862,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping WeeklyAvailable = new PixelMapping
		{
			X = 541,
			Y = 74,
			Color = 13051648,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping WeeklyTab = new PixelMapping
		{
			X = 638,
			Y = 92,
			Color = 0,
			Type = MappingType.BUTTON
		};
	}
}
