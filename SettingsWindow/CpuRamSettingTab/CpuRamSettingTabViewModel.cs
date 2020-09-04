using System;
using System.Collections.ObjectModel;

using Common;

namespace SettingsWindow
{
	public class CpuAllocationViewModel : ViewModel, ICpuAllocationViewModel
	{
		public Allocation Allocation { get; set; }
		public int Cores { get; set; }
		public string DisplayText { get; set; }
	}

	public class RamAllocationViewModel : ViewModel, IRamAllocationViewModel
	{
		public Allocation Allocation { get; set; }
		public int Ram { get; set; }
		public string DisplayText { get; set; }
	}

	public class CpuRamSettingTabViewModel : ViewModel, ICpuRamSettingTabViewModel
	{
		public ICpuAllocationViewModel SelectedCpuAllocation { get; set; }
		public ObservableCollection<ICpuAllocationViewModel> CpuAllocations { get; set; }
		public IRamAllocationViewModel SelectedRamAllocation { get; set; }
		public ObservableCollection<IRamAllocationViewModel> RamAllocations { get; set; }
		public int FrameRates { get; set; }
		public bool EnableHighFrameRates { get; set; }
		public bool DisplayFPS { get; set; }
		public bool IsDirty { get; set; }
		public string VmName { get; set; }
		public bool IsGuestBooted { get; set; }

		public bool AreMyChildsDirty()
		{
			throw new NotImplementedException();
		}

		public void IsRestartNeeded()
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
