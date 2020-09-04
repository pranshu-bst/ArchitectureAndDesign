using System;
using System.ComponentModel;

namespace SettingsWindow
{
	public class DebuggingPreferencesSettingTabViewModel : IDebuggingPreferencesSettingTabViewModel
	{
		public bool EnableAndroidDebugBridge { get; set; }
		public bool EnableInputDebugging { get; set; }
		public bool IsDirty { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		public bool AreMyChildsDirty()
		{
			throw new NotImplementedException();
		}

		public void OnDiscard()
		{
			throw new NotImplementedException();
		}

		public void OnInit()
		{
			throw new NotImplementedException();
		}

		public void OnSave()
		{
			throw new NotImplementedException();
		}
	}
}
