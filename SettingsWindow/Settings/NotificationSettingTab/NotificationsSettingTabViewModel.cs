using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

using Common;

namespace BlueStacks.BlueStacksUI
{
	public class AppNotificationViewModel : ViewModel, IAppNotificationViewModel
	{
		public string Game { get; set; }
		public bool Bell { get; set; }
		public bool Desktop { get; set; }
		public bool IsDirty { get; set; }

		public bool AreMyChildsDirty()
		{
			throw new NotImplementedException();
		}
	}
	public class NotificationsSettingTabViewModel : ViewModel, INotificationsSettingTabViewModel
	{
		public bool EnableNotificatioMode { get; set; }
		public bool DoNotShowNotificationModePopup { get; set; }
		public ICommand NotificationModeReadMore { get; set; }
		public bool EnableNotifcationSounds { get; set; }
		public bool EnableRibbonNotificaions { get; set; }
		public bool EnableToastNotifcation { get; set; }
		public ObservableCollection<IAppNotificationViewModel> AppNotifications { get; set; }
		public bool IsDirty { get; set; }
		public string VmName { get; set; }
		public bool IsGuestBooted { get; set; }

		public bool AreMyChildsDirty()
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
