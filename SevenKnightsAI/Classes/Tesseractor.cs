using SevenKnightsAI.Properties;
using System;
using System.IO;
using System.Windows.Forms;
using Tesseract;

namespace SevenKnightsAI.Classes
{
    internal class Tesseractor
    {
        public Tesseractor(string language = "eng")
        {
            string productVersion = Application.ProductVersion;
            string tempPath = Utility.GetTempPath();
            string text = tempPath + "tessdata";
            if (!Directory.Exists(text))
            {
                Console.WriteLine("Extracting tessdata");
                Tesseractor.ExtractFiles(text);
                Tesseractor.CreateVersionFile(text, productVersion);
            }
            else
            {
                int num = Convert.ToInt32(productVersion.Replace(".", ""));
                string text2 = File.ReadAllText(text + "\\version");
                int num2 = Convert.ToInt32(text2.Replace(".", ""));
                if (num2 < num)
                {
                    Console.WriteLine("Migrating tessdata");
                    Tesseractor.ExtractFiles(text);
                    Tesseractor.CreateVersionFile(text, productVersion);
                }
            }
            this.Engine = new TesseractEngine(text, language, EngineMode.Default);
        }

        private static void CreateVersionFile(string dataPath, string assemblyVersion)
        {
            File.WriteAllText(dataPath + "\\version", assemblyVersion);
        }

        private static void ExtractFiles(string dataPath)
        {
            byte[] tessdata = Resources.tessdata;
            string text = dataPath + ".zip";
            FileStream fileStream = new FileStream(text, FileMode.Create, FileAccess.Write);
            fileStream.Write(tessdata, 0, tessdata.Length);
            fileStream.Close();
            ArchiveManager.Extract(text, dataPath, null);
            if (File.Exists(text))
            {
                File.Delete(text);
            }
        }

        public TesseractEngine Engine
        {
            get;
            private set;
        }
    }
}