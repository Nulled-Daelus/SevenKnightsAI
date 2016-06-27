using System;

namespace SevenKnightsAI.Classes.Mappings
{
	internal static class AdventureModesPM
	{
		#region Public Fields

		public static readonly PixelMapping AdventureButton = new PixelMapping
		{
			X = 254,
			Y = 200,
			Color = 0,
			Type = MappingType.BUTTON
		};

		public static readonly PixelMapping BorderBottomRight = new PixelMapping
		{
			X = 297,
			Y = 203,
			Color = 4618634,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping BorderTopLeft = new PixelMapping
		{
			X = 205,
			Y = 127,
			Color = 4396809,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping CelestialTowerButton = new PixelMapping
		{
			X = 704,
			Y = 200,
			Color = 0,
			Type = MappingType.BUTTON
		};

		public static readonly PixelMapping DailyDungeonButton = new PixelMapping
		{
			X = 254,
			Y = 460,
			Color = 0,
			Type = MappingType.BUTTON
		};

		public static readonly int GOLD_OFFSET_X = 355;
		public static readonly int GOLD_OFFSET_Y = 0;
		public static readonly int KEY_OFFSET_X = 347;
		public static readonly int KEY_OFFSET_Y = 0;
		
		public static readonly PixelMapping KeyIcon = new PixelMapping
		{
			X = 404,
			Y = 22,
			Color = 13649463,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping RaidButton = new PixelMapping
		{
			X = 704,
			Y = 460,
			Color = 0,
			Type = MappingType.BUTTON
		};

		public static readonly int RUBY_OFFSET_X = 364;
		public static readonly int RUBY_OFFSET_Y = 0;
		#endregion Public Fields
	}
}