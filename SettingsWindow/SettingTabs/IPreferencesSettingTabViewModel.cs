
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

using Common;

namespace SettingsWindow
{
	public interface IPlateformPreferencesSettingTabViewModel : IDynamicViewModel
	{
		public ICodeDescriptionViewModel SelectedLanguage { get; set; }
		public ObservableCollection<ICodeDescriptionViewModel> Languages { get; set; }
		public bool CreateDesktopShortcuts { get; set; }
		public bool ConnectToDiscord { get; set; }

		public string MediaFolderLocation { get; set; }
		public ICommand	ChangeMediaFolderLocation { get; set; }
		public bool EnableAccessToMediaFilesOnWindows { get; set; }

		public bool EnableWarningOnControlSchemeDelete { get; set; }

		public bool EnableWarningOnMacroScriptDelete { get; set; }
	}
	public interface IPerformancePreferencesSettingTabViewModel : IDynamicViewModel
	{
		public bool EnableStandardSwitchingBetweenApps { get; set; }
		public bool CloseWebPagesWhenRunningGames { get; set; }
		public bool EnablePeriodicMemoryTrimming { get; set; }
	}
	public interface IDebuggingPreferencesSettingTabViewModel : IDynamicViewModel 
	{
		public bool EnableAndroidDebugBridge { get; set; }
		public bool EnableInputDebugging { get; set; }
	}

	public interface IPreferencesSettingTabViewModel : IDynamicViewModel
	{
		public IPlateformPreferencesSettingTabViewModel PlateformPreferencesSettingTab { get; set; }
		public IPerformancePreferencesSettingTabViewModel PerformancePreferencesSettingTab { get; set; }
		public IDebuggingPreferencesSettingTabViewModel DebuggingPreferencesSettingTab { get; set; }


		public List<IDynamicViewModel> PreferencesSettingTabs { get; set; }
	}


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
