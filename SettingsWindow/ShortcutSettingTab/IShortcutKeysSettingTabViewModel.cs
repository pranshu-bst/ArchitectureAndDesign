using System.Collections.ObjectModel;

using Common;

namespace SettingsWindow
{
	public interface IShortcutViewModel: IViewModel
	{
		public string ActionName { get; set; }
		public string ActionKey { get; set; }
	}
	public interface ICategoryShortcutsViewModel : IViewModel 
	{
		public string Category { get; set; }
		public ObservableCollection<IShortcutViewModel> Shortcuts { get; set; }
	}
	public interface IShortcutKeysSettingTabViewModel : IDynamicViewModel, IInstanceInfo
	{
		public ObservableCollection<ICategoryShortcutsViewModel> CategoryShortcuts { get; set; }
	}
}
