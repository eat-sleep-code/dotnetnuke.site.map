using System;

namespace DONEIN_NET.Site_Map
{
	public class ModuleLocalization
	{
		public String GetString(String resourceKey, String resourceFile)
		{
			string text = String.Empty;
		
			// LOOK FOR LOCALIZED TEXT
			try
			{
				text = DotNetNuke.Services.Localization.Localization.GetString(resourceKey, resourceFile).Trim();
			}
			catch //(Exception ex)
			{
				return String.Empty;
			}

			return text;
		}
	}
}
