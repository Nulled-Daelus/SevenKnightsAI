using System;
using System.IO;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;

namespace SevenKnightsAI.Classes
{
	
	internal static class ArchiveManager
	{
		
		public static void Extract(string archiveFilenameIn, string outFolder, string password = null)
		{
			ZipFile zipFile = null;
			try
			{
				FileStream file = File.OpenRead(archiveFilenameIn);
				zipFile = new ZipFile(file);
				if (!string.IsNullOrEmpty(password))
				{
					zipFile.Password = password;
				}
				foreach (ZipEntry zipEntry in zipFile)
				{
					if (zipEntry.IsFile)
					{
						string name = zipEntry.Name;
						byte[] buffer = new byte[4096];
						Stream inputStream = zipFile.GetInputStream(zipEntry);
						string path = Path.Combine(outFolder, name);
						string directoryName = Path.GetDirectoryName(path);
						if (directoryName.Length > 0)
						{
							Directory.CreateDirectory(directoryName);
						}
						using (FileStream fileStream = File.Create(path))
						{
							StreamUtils.Copy(inputStream, fileStream, buffer);
						}
					}
				}
			}
			finally
			{
				if (zipFile != null)
				{
					zipFile.IsStreamOwner = true;
					zipFile.Close();
				}
			}
		}
	}
}
