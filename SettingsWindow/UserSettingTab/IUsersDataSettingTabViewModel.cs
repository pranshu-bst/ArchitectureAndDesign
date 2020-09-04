
using System.Windows.Input;

using Common;

namespace SettingsWindow
{
	public interface IUsersDataSettingTabViewModel : IViewModel, IInstanceInfo
	{
		public ICommand	StartCleanup { get; set; }
		public ICommand RestoreData { get; set; }
		public ICommand BackupData { get; set; }
	}
}
