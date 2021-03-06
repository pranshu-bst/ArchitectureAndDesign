﻿using System.Collections.ObjectModel;

using Common;

namespace BlueStacks.BlueStacksUI
{
	public interface IDisplayResolutionViewModel: IViewModel {
		public DisplayOrientation DisplayOrientation { get; set; }
		public int Height { get; set; }
		public int Width { get; set; }
		public string CombinedResolution { get; set; }
	}

	public interface IDisplaySettingTabViewModel : IDynamicViewModel,IInstanceInfo, INeedRestart
	{
		public DisplayOrientation DisplayOrientation { get; set; }
		public IDisplayResolutionViewModel SelectedDisplayResolution { get; set; }
		ObservableCollection<IDisplayResolutionViewModel> DisplayResolutions { get; set; }
		public PixelDensity PixelDensity { get; set; }
	}
}
