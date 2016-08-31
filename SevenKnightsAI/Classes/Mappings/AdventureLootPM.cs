using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdventureLootPM
    {
        public static readonly PixelMapping AdventureButton = new PixelMapping
        {
            X = 886,
            Y = 368,
            Color = 9332787,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping AgainButton = new PixelMapping
        {
            X = 884,
            Y = 150,
            Color = 5383183,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping NextZoneButton = new PixelMapping
        {
            X = 884,
            Y = 250,
            Color = 4924176,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping QuickStartButton = new PixelMapping
        {
            X = 786,
            Y = 480,
            Color = 5317647,
            Type = MappingType.BOTH
        };
    }
}