using System.Collections.ObjectModel;

using Common;

namespace SettingsWindow
{
	public interface IShortcut: IViewModel
	{
		public string ActionName { get; set; }
		public string ActionKey { get; set; }
	}
	public interface ICategoryShortcuts : IViewModel 
	{
		public string Category { get; set; }
		public ObservableCollection<IShortcut> Shortcuts { get; set; }
	}
	public interface IShortcutKeysSettingTabViewModel : IDynamicViewModel
	{
		public ObservableCollection<ICategoryShortcuts> CategoryShortcuts { get; set; }
	}
}
