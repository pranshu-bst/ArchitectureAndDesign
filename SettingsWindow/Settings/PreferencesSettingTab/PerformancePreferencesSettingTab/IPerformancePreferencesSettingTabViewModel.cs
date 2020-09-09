using Common;

namespace BlueStacks.BlueStacksUI
{
	public interface IPerformancePreferencesSettingTabViewModel : IDynamicViewModel
	{
		public bool EnableStandardSwitchingBetweenApps { get; set; }
		public bool CloseWebPagesWhenRunningGames { get; set; }
		public bool EnablePeriodicMemoryTrimming { get; set; }
	}
}
