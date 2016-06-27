using System;

namespace SevenKnightsAI.Classes.Mappings
{
	internal static class QuestSelectPM
	{
		#region Public Fields

		public static readonly PixelMapping QuestAvailable = new PixelMapping
		{
			X = 501,
			Y = 225,
			Color = 13051648,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping QuestButton = new PixelMapping
		{
			X = 558,
			Y = 270,
			Color = 0,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping QuestIcon = new PixelMapping
		{
			X = 536,
			Y = 231,
			Color = 16642681,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping SpecialQuestAvailable = new PixelMapping
		{
			X = 347,
			Y = 225,
			Color = 13051648,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping SpecialQuestButton = new PixelMapping
		{
			X = 402,
			Y = 270,
			Color = 0,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping SpecialQuestIcon = new PixelMapping
		{
			X = 390,
			Y = 233,
			Color = 15931924,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping TitleBorderLeft = new PixelMapping
		{
			X = 268,
			Y = 180,
			Color = 0,
			Type = MappingType.ANCHOR
		};

		public static readonly PixelMapping TitleBorderRight = new PixelMapping
		{
			X = 690,
			Y = 180,
			Color = 0,
			Type = MappingType.ANCHOR
		};

		#endregion Public Fields
	}
}