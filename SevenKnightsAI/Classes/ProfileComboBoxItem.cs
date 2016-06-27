using System;
using System.Collections.Generic;

namespace SevenKnightsAI.Classes
{
	
	internal class ProfileComboBoxItem
	{
		
		public ProfileComboBoxItem(KeyValuePair<string, AISettings> entry)
		{
			this.Key = entry.Key;
			this.Text = this.Key.Substring(this.Key.IndexOf('\\') + 1).Replace(AIProfiles.FILE_EXTENSION, "");
			this.Value = entry.Value;
		}

		
		public override string ToString()
		{
			return this.Text;
		}

		
		public string Key;
		
		public string Text;
		
		public AISettings Value;	}
}
