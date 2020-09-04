
using System.Collections.ObjectModel;

using Common;

namespace SettingsWindow
{

	public interface ICpuAllocationViewModel : IViewModel
	{
		public Allocation Allocation { get; set; }
		public int Cores { get; set; }
		public string DisplayText { get; set; }
	}

	public interface IRamAllocationViewModel : IViewModel
	{
		public Allocation Allocation { get; set; }
		public int Ram { get; set; }
		public string DisplayText { get; set; }
	}

	public interface ICpuRamSettingTabViewModel : IDynamicViewModel,IInstanceInfo, INeedRestart
	{
		public ICpuAllocationViewModel SelectedCpuAllocation { get; set; }
		ObservableCollection<ICpuAllocationViewModel> CpuAllocations { get; set; }
		public IRamAllocationViewModel SelectedRamAllocation { get; set; }
		ObservableCollection<IRamAllocationViewModel> RamAllocations { get; set; }

		public int FrameRates { get; set; }
		public bool EnableHighFrameRates { get; set; }
		public bool DisplayFPS { get; set; }
	}
}
