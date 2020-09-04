
using System.Windows.Input;

using Common;

namespace SettingsWindow
{
	public interface IGameSettingViewModel : IDynamicViewModel 
	{
		public InGameResolution InGameResolution { get; set; }
		public GraphicQuality GraphicQuality { get; set; }
		public string MouseSenstivity { get; set; }
		public bool ForcePortraitMode { get; set; }
	}

	public interface IGameSettingTabViewModel : IDynamicViewModel, IInstanceInfo, IPackageInfo
	{
		public GameCuror GameCuror { get; set; }
		public bool EnableGamepadDetection { get; set; }
		public bool ForceNativeGamepadWhenSupported { get; set; }

		public  ICommand ShowGuide { get; set; }

		public IGameSettingViewModel GameSeting { get; set; }
	}
}
