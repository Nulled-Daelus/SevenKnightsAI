using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
	internal static class AdventureStartPM
	{
		#region Public Fields
		public static readonly int GOLD_OFFSET_X = 514;
		public static readonly int GOLD_OFFSET_Y = 0;

		public static readonly int KEY_OFFSET_X = 509;
		public static readonly int KEY_OFFSET_Y = 0;

		public static readonly PixelMapping KeyPlusButton = new PixelMapping
		{
			X = 662,
			Y = 28,
			Color = 12690781,
			Type = MappingType.ANCHOR
		};

		public static readonly Rectangle R_MapNumber = new Rectangle
		{
			X = 355,
			Y = 12,
			Width = 88,
			Height = 33
		};

		#endregion Public Fields
	}
}