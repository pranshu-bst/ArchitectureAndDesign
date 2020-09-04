using Common;

namespace SettingsWindow
{
	public interface IDebuggingPreferencesSettingTabViewModel : IDynamicViewModel
	{
		public bool EnableAndroidDebugBridge { get; set; }
		public bool EnableInputDebugging { get; set; }
	}
}
