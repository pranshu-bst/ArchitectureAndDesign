using System.Windows.Input;

using Common;

namespace SettingsWindow
{
	public class UsersDataSettingTabViewModel : ViewModel, IUsersDataSettingTabViewModel
	{
		public ICommand StartCleanup { get; set; }
		public ICommand RestoreData { get; set; }
		public ICommand BackupData { get; set; }
	}
}
