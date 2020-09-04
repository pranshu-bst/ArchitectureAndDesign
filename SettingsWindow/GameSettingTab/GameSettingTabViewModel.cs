using System;
using System.Windows.Input;

using Common;

namespace SettingsWindow
{
	public class GameSettingViewModel : ViewModel, IGameSettingViewModel
	{
		public InGameResolution InGameResolution { get; set; }
		public GraphicQuality GraphicQuality { get; set; }
		public string MouseSenstivity { get; set; }
		public bool ForcePortraitMode { get; set; }
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
	public class GameSettingTabViewModel : ViewModel, IGameSettingTabViewModel
	{
		public GameCuror GameCuror { get; set; }
		public bool EnableGamepadDetection { get; set; }
		public bool ForceNativeGamepadWhenSupported { get; set; }
		public ICommand ShowGuide { get; set; }
		public IGameSettingViewModel GameSeting { get; set; }
		public bool IsDirty { get; set; }
		public string VmName { get; set; }
		public bool IsGuestBooted { get; set; }
		public string AppName { get; set; }
		public string PackageInfo { get; set; }

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
