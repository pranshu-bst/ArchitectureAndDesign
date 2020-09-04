using System;
using System.Collections.ObjectModel;

using Common;

namespace SettingsWindow
{
	public class ShortcutViewModel : ViewModel, IShortcutViewModel
	{
		public string ActionName { get; set; }
		public string ActionKey { get; set; }
	}
	public class CategoryShortcutsViewModel : ViewModel, ICategoryShortcutsViewModel
	{
		public string Category { get; set; }
		public ObservableCollection<IShortcutViewModel> Shortcuts { get; set; }
	}
	public class ShortcutKeysSettingTabViewModel : ViewModel, IShortcutKeysSettingTabViewModel
	{
		public ObservableCollection<ICategoryShortcutsViewModel> CategoryShortcuts { get; set; }
		public bool IsDirty { get; set; }

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
