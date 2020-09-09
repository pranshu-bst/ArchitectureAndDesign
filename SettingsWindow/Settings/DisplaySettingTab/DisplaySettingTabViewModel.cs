using System;
using System.Collections.ObjectModel;

using Common;

namespace BlueStacks.BlueStacksUI
{
	public class DisplayResolutionViewModel : ViewModel, IDisplayResolutionViewModel
	{
		public DisplayOrientation DisplayOrientation { get; set; }
		public int Height { get; set; }
		public int Width { get; set; }
		public string CombinedResolution { get; set; }
	}

	public class DisplaySettingTabViewModel : ViewModel, IDisplaySettingTabViewModel
	{
		public DisplayOrientation DisplayOrientation { get; set; }
		public IDisplayResolutionViewModel SelectedDisplayResolution { get; set; }
		public ObservableCollection<IDisplayResolutionViewModel> DisplayResolutions { get; set; }
		public PixelDensity PixelDensity { get; set; }
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
