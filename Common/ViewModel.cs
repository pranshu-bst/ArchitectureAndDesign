using System.ComponentModel;

namespace Common
{
	public class ViewModel : IViewModel
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyChange(string propName) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
		}
	}
}
