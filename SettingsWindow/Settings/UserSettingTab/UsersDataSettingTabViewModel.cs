using System.Windows.Input;

using Common;

namespace BlueStacks.BlueStacksUI
{
	public class UsersDataSettingTabViewModel : ViewModel, IUsersDataSettingTabViewModel
	{
		public ICommand StartCleanup { get; set; }
		public ICommand RestoreData { get; set; }
		public ICommand BackupData { get; set; }
		public string VmName { get; set; }
		public bool IsGuestBooted { get; set; }
	}
}
