using System;

namespace SevenKnightsAI.Classes.Mappings
{
	internal static class HeroJoinPM
	{
		#region Public Fields

		public static readonly PixelMapping JoinButton = new PixelMapping
		{
			X = 848,
			Y = 485,
			Color = 11832633,
			Type = MappingType.BOTH
		};

		public static readonly PixelMapping JoinButtonIcon = new PixelMapping
		{
			X = 861,
			Y = 456,
			Color = 15058003,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping SellButton = new PixelMapping
		{
			X = 594,
			Y = 481,
			Color = 16049282,
			Type = MappingType.BOTH
		};

		#endregion Public Fields
	}
}