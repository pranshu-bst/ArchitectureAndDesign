using System.Collections.ObjectModel;

using Common;

namespace SettingsWindow
{
	public interface IAdvancedSettingTabViewModel : IDynamicViewModel
	{
		public ABIValue ABIValue { get; set; }
		public string SelectedDeviceProfile { get; set; }
		public ObservableCollection<string> DeviceProfiles { get; set; }

		public string SelectedNetworkProvider { get; set; }
		public ObservableCollection<string> NetworkProviders { get; set; }
	}
}
