
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
	public interface DebuggingPreferencesSettingTabViewModel : IDynamicViewModel 
	{
		public bool EnableAndroidDebugBridge { get; set; }
		public bool EnableInputDebugging { get; set; }
	}

	public interface IPreferencesSettingTabViewModel : IDynamicViewModel
	{
		public IPlateformPreferencesSettingTabViewModel IPlateformPreferencesSettingTabViewModel { get; set; }
		public IPerformancePreferencesSettingTabViewModel IPerformancePreferencesSettingTabViewModel { get; set; }
		public DebuggingPreferencesSettingTabViewModel DebuggingPreferencesSettingTabViewModel { get; set; }


		public List<IDynamicViewModel> PreferencesSettingTabs { get; set; }
	}


	//public class PreferencesSettingTabViewModel :ViewModel, IPreferencesSettingTabViewModel
	//{
	//	public IPlateformPreferencesSettingTabViewModel IPlateformPreferencesSettingTabViewModel { get; set; }
	//	public IPerformancePreferencesSettingTabViewModel IPerformancePreferencesSettingTabViewModel { get; set; }
	//	public DebuggingPreferencesSettingTabViewModel DebuggingPreferencesSettingTabViewModel { get; set; }
	//	public bool IsDirty { get; set; }

	//	public List<IDynamicViewModel> IPreferencesSettingTabs { get; set; } = new List<IDynamicViewModel>();

	//	public PreferencesSettingTabViewModel()
	//	{
	//		// Initialise all Preferences setting tab models
	//		// Add tab models to list
	//	}

	//	public bool AreMyChildsDirty()
	//	{
	//		return IPreferencesSettingTabs.Any(tab => tab.IsDirty || tab.AreMyChildsDirty());
	//	}

	//	public void OnDiscard()
	//	{
	//		IPreferencesSettingTabs.ForEach(tab => tab.OnDiscard());
	//	}

	//	public void OnInit()
	//	{
	//		IPreferencesSettingTabs.ForEach(tab => tab.OnInit());
	//	}

	//	public void OnSave()
	//	{
	//		IPreferencesSettingTabs.ForEach(tab => tab.OnSave());
	//	}
	//}
}
