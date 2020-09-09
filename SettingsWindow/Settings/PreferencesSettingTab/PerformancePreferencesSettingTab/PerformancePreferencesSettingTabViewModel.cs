using System;

using Common;

namespace BlueStacks.BlueStacksUI
{
	public class PerformancePreferencesSettingTabViewModel : ViewModel, IPerformancePreferencesSettingTabViewModel
	{
		public bool EnableStandardSwitchingBetweenApps { get; set; }
		public bool CloseWebPagesWhenRunningGames { get; set; }
		public bool EnablePeriodicMemoryTrimming { get; set; }
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
