using System;

namespace SevenKnightsAI.Classes.Mappings
{
	internal static class TapToPlayPM
	{
		#region Public Fields

		// Just a point on the TapToPlay screen to detect it.
		public static readonly PixelMapping Point1 = new PixelMapping
		{
			X = 66,
			Y = 138,
			Color = 14663800,
            Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping TapArea = new PixelMapping
		{
			X = 477,
			Y = 486,
			Color = 0,
			Type = MappingType.BUTTON
		};

		#endregion Public Fields
	}
}