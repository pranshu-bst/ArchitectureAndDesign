using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

using Common;

namespace SettingsWindow
{
	public class SettingsViewModel : ViewModel, ISettingsViewModel
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
		public ICommand Reset { get; set; }
		public ICommand Save { get; set; }
		public ICommand Close { get; set; }
		public bool IsDirty { get; set; }


		public bool AreMyChildsDirty()
		{
			return SettingTabs.OfType<IDynamicViewModel>().Any(tab => tab.IsDirty || tab.AreMyChildsDirty());
		}

		public void OnDiscard()
		{
			SettingTabs.OfType<IDynamicViewModel>().ToList().ForEach(tab => tab.OnDiscard());
		}

		public void OnInit()
		{
			SettingTabs.OfType<IDynamicViewModel>().ToList().ForEach(tab => tab.OnInit());
		}

		public void OnSave()
		{
			SettingTabs.OfType<IDynamicViewModel>().ToList().ForEach(tab => tab.OnSave());
		}
	}
}
