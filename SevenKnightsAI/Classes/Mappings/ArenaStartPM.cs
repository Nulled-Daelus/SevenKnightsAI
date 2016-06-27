using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
	internal static class ArenaStartPM
	{
		#region Public Fields

		public static readonly PixelMapping CombatTeamBorderLeft = new PixelMapping
		{
			X = 43,
			Y = 70,
			Color = 13863428,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping CombatTeamBorderRight = new PixelMapping
		{
			X = 326,
			Y = 70,
			Color = 13863428,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping FormationBorderLeft = new PixelMapping
		{
			X = 345,
			Y = 137,
			Color = 15587227,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping FormationBorderRight = new PixelMapping
		{
			X = 927,
			Y = 137,
			Color = 15587227,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping FormationSelectBalance = new PixelMapping
		{
			X = 776,
			Y = 200,
			Color = 0,
			Type = MappingType.BUTTON
		};

		public static readonly PixelMapping FormationSelectBasic = new PixelMapping
		{
			X = 488,
			Y = 200,
			Color = 0,
			Type = MappingType.BUTTON
		};

		public static readonly PixelMapping FormationSelectDefense = new PixelMapping
		{
			X = 776,
			Y = 374,
			Color = 0,
			Type = MappingType.BUTTON
		};

		public static readonly PixelMapping FormationSelectOffense = new PixelMapping
		{
			X = 488,
			Y = 374,
			Color = 0,
			Type = MappingType.BUTTON
		};

		public static readonly int HONOR_OFFSET_X = 227;

		public static readonly int HONOR_OFFSET_Y = 0;

		public static readonly PixelMapping Key_0 = new PixelMapping
		{
			X = 400,
			Y = 22,
			Color = 9405048,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping Key_1 = new PixelMapping
		{
			X = 423,
			Y = 21,
			Color = 7760222,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping Key_2 = new PixelMapping
		{
			X = 448,
			Y = 22,
			Color = 8352360,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping Key_3 = new PixelMapping
		{
			X = 473,
			Y = 22,
			Color = 8155238,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping Key_4 = new PixelMapping
		{
			X = 496,
			Y = 21,
			Color = 6970706,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping ManageButton = new PixelMapping
		{
			X = 280,
			Y = 500,
			Color = 0,
			Type = MappingType.BUTTON
		};

		public static readonly PixelMapping Mastery_1 = new PixelMapping
		{
			X = 315,
			Y = 125,
			Color = 16637984,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping Mastery_2 = new PixelMapping
		{
			X = 319,
			Y = 136,
			Color = 15257116,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping Mastery_3 = new PixelMapping
		{
			X = 320,
			Y = 132,
			Color = 16769568,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping MasteryButton = new PixelMapping
		{
			X = 302,
			Y = 156,
			Color = 0,
			Type = MappingType.BUTTON
		};

		public static readonly Rectangle R_Time = new Rectangle
		{
			X = 517,
			Y = 19,
			Width = 48,
			Height = 20
		};

		public static readonly int RUBY_OFFSET_X = 224;

		public static readonly int RUBY_OFFSET_Y = 0;

		public static readonly PixelMapping StartButton = new PixelMapping
		{
			X = 636,
			Y = 500,
			Color = 0,
			Type = MappingType.BUTTON
		};

		#endregion Public Fields
	}
}