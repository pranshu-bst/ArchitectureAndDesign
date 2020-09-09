using System.Collections.ObjectModel;
using System.Windows.Input;

using Common;

namespace BlueStacks.BlueStacksUI
{
	public interface IPlateformPreferencesSettingTabViewModel : IDynamicViewModel, INeedRestart
	{
		public ICodeDescriptionViewModel SelectedLanguage { get; set; }
		public ObservableCollection<ICodeDescriptionViewModel> Languages { get; set; }
		public bool CreateDesktopShortcuts { get; set; }
		public bool ConnectToDiscord { get; set; }

		public string MediaFolderLocation { get; set; }
		public ICommand ChangeMediaFolderLocation { get; set; }
		public bool EnableAccessToMediaFilesOnWindows { get; set; }

		public bool EnableWarningOnControlSchemeDelete { get; set; }

		public bool EnableWarningOnMacroScriptDelete { get; set; }
	}
}
