namespace SevenKnightsAI.Classes.Mappings
{
    internal static class HeroesSameTeamPopupPM
    {
        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 343,
            Y = 85,
            Color = 4603937,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderLeft = new PixelMapping
        {
            X = 260,
            Y = 195,
            Color = 15126678,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderRight = new PixelMapping
        {
            X = 698,
            Y = 195,
            Color = 15126678,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TapArea = new PixelMapping
        {
            X = 474,
            Y = 400,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}