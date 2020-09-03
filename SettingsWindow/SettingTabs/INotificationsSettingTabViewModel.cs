using System.Collections.ObjectModel;
using System.Windows.Input;

using Common;

namespace SettingsWindow
{

	public interface IAppNotificationViewModel : IViewModel, IAmDirty
	{
		public string Game { get; set; }
		public bool Bell { get; set; }
		public bool Desktop { get; set; }
	}

	public interface INotificationsSettingTabViewModel : IDynamicViewModel
	{
		public bool NotificatioMode { get; set; }
		public bool DoNotShowNotificationModePopup { get; set; }
		public ICommand NotificationModeReadMore { get; set; }


		public bool NotifcationSounds { get; set; }
		public bool RibbonNotificaions { get; set; }
		public bool ToatNotifcation { get; set; }

		ObservableCollection<IAppNotificationViewModel> AppNotificationViewModels { get; set; }
	}
}
