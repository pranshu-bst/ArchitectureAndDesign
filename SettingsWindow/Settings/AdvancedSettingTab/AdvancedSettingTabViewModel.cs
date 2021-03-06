﻿using System;
using System.Collections.ObjectModel;

using Common;

namespace BlueStacks.BlueStacksUI
{
	public class AdvancedSettingTabViewModel : ViewModel, IAdvancedSettingTabViewModel
	{
		public ABIValue ABIValue { get; set; }
		public string SelectedDeviceProfile { get; set; }
		public ObservableCollection<string> DeviceProfiles { get; set; }
		public string SelectedNetworkProvider { get; set; }
		public ObservableCollection<string> NetworkProviders { get; set; }
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
