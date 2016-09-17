using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidRewardPM
    {
        public static readonly PixelMapping MemberListBackground = new PixelMapping
        {
            //X = 40,
            //Y = 69,
            //Color = 1708300,
            X = 36,
            Y = 86,
            Color = 2233613,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardButton = new PixelMapping
        {
            //X = 830,
            //Y = 424,
            //Color = 0,
            X = 823,
            Y = 413,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RewardButtonBackground = new PixelMapping
        {
            //X = 830,
            //Y = 438,
            //Color = 16771586,
            X = 820,
            Y = 413,
            Color = 13864707,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardButtonRedIcon = new PixelMapping
        {
            X = 755,
            Y = 402,
            Color = 13183233,
            Type = MappingType.ANCHOR
        };
    }
}