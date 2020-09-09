using System.Collections.ObjectModel;
using System.Windows.Input;

using Common;

namespace BlueStacks.BlueStacksUI
{
	public interface IAppNotificationViewModel : IViewModel, IAmDirty
	{
		public string Game { get; set; }
		public bool Bell { get; set; }
		public bool Desktop { get; set; }
	}

	public interface INotificationsSettingTabViewModel : IDynamicViewModel, IInstanceInfo
	{
		public bool EnableNotificatioMode { get; set; }
		public bool DoNotShowNotificationModePopup { get; set; }
		public ICommand NotificationModeReadMore { get; set; }


		public bool EnableNotifcationSounds { get; set; }
		public bool EnableRibbonNotificaions { get; set; }
		public bool EnableToastNotifcation { get; set; }

		ObservableCollection<IAppNotificationViewModel> AppNotifications { get; set; }
	}
}
