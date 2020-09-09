
using System.Windows.Input;

using Common;

namespace BlueStacks.BlueStacksUI
{
	public interface IUsersDataSettingTabViewModel : IViewModel, IInstanceInfo
	{
		public ICommand	StartCleanup { get; set; }
		public ICommand RestoreData { get; set; }
		public ICommand BackupData { get; set; }
	}
}
