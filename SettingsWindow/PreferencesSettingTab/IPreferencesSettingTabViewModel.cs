using System.Collections.Generic;

using Common;

namespace SettingsWindow
{
	public interface IPreferencesSettingTabViewModel : IDynamicViewModel
	{
		public IPlateformPreferencesSettingTabViewModel PlateformPreferencesSettingTab { get; set; }
		public IPerformancePreferencesSettingTabViewModel PerformancePreferencesSettingTab { get; set; }
		public IDebuggingPreferencesSettingTabViewModel DebuggingPreferencesSettingTab { get; set; }


		public List<IDynamicViewModel> PreferencesSettingTabs { get; set; }
	}
}
