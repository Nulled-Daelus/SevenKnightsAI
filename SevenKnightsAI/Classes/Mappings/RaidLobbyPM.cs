using System;

namespace SevenKnightsAI.Classes.Mappings
{
	
	internal static class RaidLobbyPM
	{
		
		public static readonly PixelMapping AttackedTab = new PixelMapping
		{
			X = 120,
			Y = 91,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping DefeatedTab = new PixelMapping
		{
			X = 470,
			Y = 91,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping EnterButton = new PixelMapping
		{
			X = 868,
			Y = 150,
			Color = 13939542,
			Type = MappingType.BOTH
		};

		
		public static readonly PixelMapping GreenIconOnNewTab = new PixelMapping
		{
			X = 214,
			Y = 69,
			Color = 45085,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping ManageParty1Border = new PixelMapping
		{
			X = 145,
			Y = 482,
			Color = 16639910,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping ManageParty1Button = new PixelMapping
		{
			X = 208,
			Y = 500,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping ManageParty2Border = new PixelMapping
		{
			X = 385,
			Y = 482,
			Color = 16639910,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping ManageParty2Button = new PixelMapping
		{
			X = 323,
			Y = 500,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping NewTab = new PixelMapping
		{
			X = 299,
			Y = 91,
			Color = 0,
			Type = MappingType.BUTTON
		};

		
		public static readonly PixelMapping RedIconOnDefeatedTab = new PixelMapping
		{
			X = 386,
			Y = 70,
			Color = 13051648,
			Type = MappingType.ANCHOR
		};

		
		public static readonly PixelMapping RefreshButton = new PixelMapping
		{
			X = 300,
			Y = 500,
			Color = 0,
			Type = MappingType.BUTTON
		};
	}
}
