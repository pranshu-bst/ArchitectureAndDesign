using System.Collections.Generic;
using System.Linq;

using Common;

namespace SettingsWindow
{
	public class PreferencesSettingTabViewModel : ViewModel, IPreferencesSettingTabViewModel
	{
		public IPlateformPreferencesSettingTabViewModel PlateformPreferencesSettingTab { get; set; }
		public IPerformancePreferencesSettingTabViewModel PerformancePreferencesSettingTab { get; set; }
		public IDebuggingPreferencesSettingTabViewModel DebuggingPreferencesSettingTab { get; set; }
		public List<IDynamicViewModel> PreferencesSettingTabs { get; set; }
		public bool IsDirty { get; set; }

		public bool AreMyChildsDirty()
		{
			return PreferencesSettingTabs.Any(tab => tab.IsDirty || tab.AreMyChildsDirty());
		}

		public void IsRestartNeeded()
		{
			throw new System.NotImplementedException();
		}

		public void OnDiscard()
		{
			PreferencesSettingTabs.ForEach(tab => tab.OnDiscard());
		}

		public void OnInit()
		{
			PreferencesSettingTabs.ForEach(tab => tab.OnInit());
		}

		public void OnSave()
		{
			PreferencesSettingTabs.ForEach(tab => tab.OnSave());
		}
	}
}
