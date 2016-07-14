namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidRewardFailedPopupPM
    {
        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 830,
            Y = 438,
            Color = 4932865,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorder = new PixelMapping
        {
            X = 260,
            Y = 195,
            Color = 15126678,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TapArea = new PixelMapping
        {
            X = 480,
            Y = 400,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}