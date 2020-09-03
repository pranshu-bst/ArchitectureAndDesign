using Common;

namespace SettingsWindow
{
	public interface ICodeDescriptionViewModel : IViewModel
	{
		public string Code { get; set; }
		public string Description { get; set; }
	}
}
