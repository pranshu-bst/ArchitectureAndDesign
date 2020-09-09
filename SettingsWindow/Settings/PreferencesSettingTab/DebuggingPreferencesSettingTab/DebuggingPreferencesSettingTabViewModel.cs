using System;

using Common;

namespace BlueStacks.BlueStacksUI
{
	public class DebuggingPreferencesSettingTabViewModel :ViewModel, IDebuggingPreferencesSettingTabViewModel
	{
		public bool EnableAndroidDebugBridge { get; set; }
		public bool EnableInputDebugging { get; set; }
		public bool IsDirty { get; set; }

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
