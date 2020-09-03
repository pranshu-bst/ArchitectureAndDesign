
using System.Collections.Generic;
using System.Windows.Input;

using Common;

namespace SettingsWindow
{
	public interface ISettingsViewModel : IViewModel, IAmDirty
	{
		public IAboutSettingTabViewModel AboutSettingTabViewModel { get; set; }
		public IAdvancedSettingTabViewModel AdvancedSettingTabViewModel { get; set; }
		public ICpuRamSettingTabViewModel CpuRamSettingTabViewModel { get; set; }
		public IDisplaySettingTabViewModel DisplaySettingTabViewModel { get; set; }
		public IGameSettingTabViewModel GameSettingTabViewModel { get; set; }
		public IGraphicsSettingTabViewModel GraphicsSettingTabViewModel { get; set; }
		public INotificationsSettingTabViewModel NotificationsSettingTabViewModel { get; set; }
		public IPreferencesSettingTabViewModel PreferencesSettingTabViewModel { get; set; }
		public IShortcutKeysSettingTabViewModel ShortcutKeysSettingTabViewModel { get; set; }
		public IUsersDataSettingTabViewModel UsersDataSettingTabViewModel { get; set; }

		public List<IViewModel> ISettingTabs { get; set; }

		public ICommand	Reset { get; set; }
		public ICommand Save { get; set; }
		public ICommand Close { get; set; }

		void OnInit();
		void OnDiscard();
		void OnSave();
	}



	//public class SettingsViewModel : ViewModel, ISettingsViewModel
	//{
	//	public ICommand Reset { get; set; }
	//	public ICommand Save { get; set; }
	//	public ICommand Close { get; set; }
	//	public bool IsDirty { get; set; }
	//	public IAboutSettingTabViewModel IAboutSettingTabViewModel { get; set; }
	//	public IAdvancedSettingTabViewModel IAdvancedSettingTabViewModel { get; set; }
	//	public ICpuRamSettingTabViewModel ICpuRamSettingTabViewModel { get; set; }
	//	public IDisplaySettingTabViewModel IDisplaySettingTabViewModel { get; set; }
	//	public IGameSettingTabViewModel IGameSettingTabViewModel { get; set; }
	//	public IGraphicsSettingTabViewModel IGraphicsSettingTabViewModel { get; set; }
	//	public INotificationsSettingTabViewModel INotificationsSettingTabViewModel { get; set; }
	//	public IPreferencesSettingTabViewModel IPreferencesSettingTabViewModel { get; set; }
	//	public IShortcutKeysSettingTabViewModel IShortcutKeysSettingTabViewModel { get; set; }
	//	public IUsersDataSettingTabViewModel IUsersDataSettingTabViewModel { get; set; }
	//	public List<IViewModel> ISettingTabs { get; set; } = new List<IViewModel>();

	//	public SettingsViewModel()
	//	{
	//		// Initialise all setting tab models
	//		// add tabsmodels to list
	//	}

	//	public bool AreMyChildsDirty()
	//	{
	//		return ISettingTabs.OfType<IDynamicViewModel>().Any(tab => tab.IsDirty || tab.AreMyChildsDirty());
	//	}

	//	public void OnDiscard()
	//	{
	//		ISettingTabs.OfType<IDynamicViewModel>().ToList().ForEach(tab => tab.OnDiscard());
	//	}

	//	public void OnInit()
	//	{
	//		ISettingTabs.OfType<IDynamicViewModel>().ToList().ForEach(tab => tab.OnInit());
	//	}

	//	public void OnSave()
	//	{
	//		ISettingTabs.OfType<IDynamicViewModel>().ToList().ForEach(tab => tab.OnSave());
	//	}
	//}
}
