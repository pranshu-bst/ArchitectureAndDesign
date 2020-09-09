using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

using Common;

namespace BlueStacks.BlueStacksUI
{
	public class PlateformPreferencesSettingTabViewModel : ViewModel, IPlateformPreferencesSettingTabViewModel
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
		public bool IsDirty { get; set; }

		public bool AreMyChildsDirty()
		{
			throw new NotImplementedException();
		}

		public void IsRestartNeeded()
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
