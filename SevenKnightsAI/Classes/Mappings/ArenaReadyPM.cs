namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaReadyPM
    {
        #region Public Fields

        public static readonly int HONOR_OFFSET_X = 218;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 738,
            Y = 503,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ReadyButtonBackground = new PixelMapping
        {
            X = 906,
            Y = 519,
            Color = 4727055,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RecordBorder = new PixelMapping
        {
            X = 740,
            Y = 67,
            Color = 1708300,
            Type = MappingType.ANCHOR
        };

        public static readonly int RUBY_OFFSET_X = 215;

        public static readonly int RUBY_OFFSET_Y = 0;

        #endregion Public Fields
    }
}