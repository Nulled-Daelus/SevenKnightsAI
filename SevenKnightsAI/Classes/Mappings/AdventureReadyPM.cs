using System;

namespace SevenKnightsAI.Classes.Mappings
{
	internal static class AdventureReadyPM
	{
		#region Public Fields

		public static readonly PixelMapping CloseButton = new PixelMapping
		{
			X = 686,
			Y = 85,
			Color = 12925963,
			Type = MappingType.BOTH
		};

		public static readonly PixelMapping ReadyButton = new PixelMapping
		{
			X = 404,
			Y = 478,
			Color = 0,
			Type = MappingType.BUTTON
		};

		public static readonly PixelMapping ReadyButtonBackground = new PixelMapping
		{
			X = 285,
			Y = 474,
			Color = 4072212,
			Type = MappingType.ANCHOR
		};

		#endregion Public Fields
	}
}