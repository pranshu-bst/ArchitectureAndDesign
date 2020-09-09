using System.Collections.Generic;

using Common;

namespace BlueStacks.BlueStacksUI
{
	public interface IPreferencesSettingTabViewModel : IDynamicViewModel, INeedRestart
	{
		public IPlateformPreferencesSettingTabViewModel PlateformPreferencesSettingTab { get; set; }
		public IPerformancePreferencesSettingTabViewModel PerformancePreferencesSettingTab { get; set; }
		public IDebuggingPreferencesSettingTabViewModel DebuggingPreferencesSettingTab { get; set; }


		public List<IDynamicViewModel> PreferencesSettingTabs { get; set; }
	}
}
