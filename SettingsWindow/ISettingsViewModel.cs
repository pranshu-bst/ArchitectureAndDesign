
using System.Collections.Generic;
using System.Windows.Input;

using Common;

namespace SettingsWindow
{
	public interface ISettingsViewModel : IDynamicViewModel, IAmDirty, INeedRestart, IPackageInfo, IInstanceInfo
	{
		public IAboutSettingTabViewModel AboutSettingTab { get; set; }
		public IAdvancedSettingTabViewModel AdvancedSettingTab { get; set; }
		public ICpuRamSettingTabViewModel CpuRamSettingTab { get; set; }
		public IDisplaySettingTabViewModel DisplaySettingTab { get; set; }
		public IGameSettingTabViewModel GameSettingTab { get; set; }
		public IGraphicsSettingTabViewModel GraphicsSettingTab { get; set; }
		public INotificationsSettingTabViewModel NotificationsSettingTab { get; set; }
		public IPreferencesSettingTabViewModel PreferencesSettingTab { get; set; }
		public IShortcutKeysSettingTabViewModel ShortcutKeysSettingTab { get; set; }
		public IUsersDataSettingTabViewModel UsersDataSettingTab { get; set; }

		public List<IViewModel> SettingTabs { get; set; }

		public ICommand	Reset { get; set; }
		public ICommand Save { get; set; }
		public ICommand Close { get; set; }

		void OnInit();
		void OnDiscard();
		void OnSave();
	}
}
