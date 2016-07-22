using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class OutOfKeysPopupPM
    {
        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 415,
            Y = 504,
            Color = 394498,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 371,
            Y = 390,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping NoButtonBorder = new PixelMapping
        {
            X = 449,
            Y = 378,
            Color = 6966579,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorder = new PixelMapping
        {
            X = 512,
            Y = 260,
            Color = 13053964,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ShopButton = new PixelMapping
        {
            X = 586,
            Y = 390,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}