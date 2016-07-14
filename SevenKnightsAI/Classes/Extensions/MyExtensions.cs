using System;
using System.IO;

namespace SevenKnightsAI.Classes.Extensions
{
    public static class MyExtensions
    {
        public static string AppendTimeStamp(this string fileName)
        {
            return Path.GetFileNameWithoutExtension(fileName) + string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now) + Path.GetExtension(fileName);
        }
    }
}