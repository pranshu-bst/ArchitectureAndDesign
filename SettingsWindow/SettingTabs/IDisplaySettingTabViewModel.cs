﻿using System.Collections.ObjectModel;

using Common;

namespace SettingsWindow
{

	public interface IDisplayResolutionViewModel: IViewModel {
		public DisplayOrientation DisplayOrientation { get; set; }
		public int Height { get; set; }
		public int Width { get; set; }
		public string CombinedResolution { get; set; }
	}

	public interface IDisplaySettingTabViewModel : IDynamicViewModel
	{
		public DisplayOrientation DisplayOrientation { get; set; }
		public IDisplayResolutionViewModel SelectedDisplayResolutionViewModel { get; set; }
		ObservableCollection<IDisplayResolutionViewModel> DisplayResolutionViewModels { get; set; }
		public PixelDensity PixelDensity { get; set; }
	}
}
