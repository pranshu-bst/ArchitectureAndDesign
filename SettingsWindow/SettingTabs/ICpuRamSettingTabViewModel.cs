
using System.Collections.ObjectModel;

using Common;

namespace SettingsWindow
{

	public interface ICpuAllocation : IViewModel 
	{
		public Allocation Allocation { get; set; }
		public int Cores { get; set; }
		public string DisplayText { get; set; }
	}

	public interface IRamAllocation : IViewModel
	{
		public Allocation Allocation { get; set; }
		public int Ram { get; set; }
		public string DisplayText { get; set; }
	}

	public interface ICpuRamSettingTabViewModel : IDynamicViewModel
	{
		public ICpuAllocation SelectedCpuAllocation { get; set; }
		ObservableCollection<ICpuAllocation> CpuAllocations { get; set; }
		public IRamAllocation SelectedRamAllocation { get; set; }
		ObservableCollection<IRamAllocation> RamAllocations { get; set; }

		public int Framerate { get; set; }
		public bool EnableHighFrameRates { get; set; }
		public bool DisplayFPS { get; set; }
	}
}
