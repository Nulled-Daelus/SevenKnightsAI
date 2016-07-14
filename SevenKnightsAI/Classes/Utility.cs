using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace SevenKnightsAI.Classes
{
    internal class Utility
    {
        public static string FilterAscii(string input)
        {
            return Regex.Replace(input, "[^\\u0000-\\u007F]", string.Empty).Replace(Environment.NewLine, string.Empty);
        }

        public static string GetTempPath()
        {
            string tempPath = Path.GetTempPath();
            string text = tempPath + "Heartcold\\SevenKnightsAI\\";
            if (!Directory.Exists(text))
            {
                Directory.CreateDirectory(text);
            }
            return text;
        }

        public static string ToTitleCase(string input)
        {
            string str = input.ToLower();
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
        }
    }
}