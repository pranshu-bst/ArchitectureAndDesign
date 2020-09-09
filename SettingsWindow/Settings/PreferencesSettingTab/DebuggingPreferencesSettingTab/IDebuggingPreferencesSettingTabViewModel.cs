using Common;

namespace BlueStacks.BlueStacksUI
{
	public interface IDebuggingPreferencesSettingTabViewModel : IDynamicViewModel
	{
		public bool EnableAndroidDebugBridge { get; set; }
		public bool EnableInputDebugging { get; set; }
	}
}
