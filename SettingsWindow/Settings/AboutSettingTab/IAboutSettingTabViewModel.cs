
using System.Windows.Input;

using Common;

namespace BlueStacks.BlueStacksUI
{
	public interface IAboutSettingTabViewModel : IViewModel
	{
		public ICommand Website { get; set; }
		public ICommand Support { get; set; }
		public ICommand SupportEmail { get; set; }
		public ICommand TermsOfUse { get; set; }
	}
}
