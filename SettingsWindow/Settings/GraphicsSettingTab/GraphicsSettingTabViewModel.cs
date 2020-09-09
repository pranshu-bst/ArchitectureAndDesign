using System;

using Common;

namespace BlueStacks.BlueStacksUI
{
	public class GraphicsSettingTabViewModel : ViewModel, IGraphicsSettingTabViewModel
	{
		public GraphicsEngineMode GraphicsEngineMode { get; set; }
		public GraphicRenderer GraphicRenderer { get; set; }
		public bool PreferDedicatedGPU { get; set; }
		public bool EnableAstcTexture { get; set; }
		public AstcTexture AstcTexture { get; set; }
		public bool EnableAstcTextureCaching { get; set; }
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
