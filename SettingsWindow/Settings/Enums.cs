namespace BlueStacks.BlueStacksUI
{
	public	enum DisplayOrientation
	{
		Landscape,
		Portrait,
		Custom,
	}

	public enum Allocation { 
		High,
		Medium,
		Low,
		Custom
	}
	public enum PixelDensity 
	{
		Low = 160,
		Medium = 240, 
		High = 320,
	}

	public enum GraphicsEngineMode 
	{
		Compatibility,
		Performance
	}
	public enum GraphicRenderer 
	{
		OpenGL,
		DirectX
	}
	public enum AstcTexture {
		Software,
		Hardware
	}

	public enum ABIValue { 
		Auto,
		ARM
	}

	public enum GameCuror
	{
		Standard,
		Special
	}

	public enum InGameResolution {
	}

	public enum GraphicQuality { 
		Auto,
		Smooth,
		Balanced,
		HD
	}
}
