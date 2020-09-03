using Common;

namespace SettingsWindow
{
	public interface IGraphicsSettingTabViewModel : IDynamicViewModel
	{
		public GraphicsEngineMode GraphicsEngineMode { get; set; }
		public GraphicRenderer GraphicRenderer { get; set; }
		public bool PreferDedicatedGPU { get; set; }
		public bool EnableAstcTexture { get; set; }
		public AstcTexture AstcTexture { get; set; }
		public bool EnableAstcTextureCaching { get; set; }
	}
}
