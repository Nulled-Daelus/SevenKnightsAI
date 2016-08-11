using System;

namespace SevenKnightsAI.Classes.Mappings
{
	internal static class TapToPlayPM
	{
		#region Public Fields

		// Just a point on the TapToPlay screen to detect it.
		public static readonly PixelMapping Point1 = new PixelMapping
		{
			X = 382,
			Y = 207,
			Color = 12366526,
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