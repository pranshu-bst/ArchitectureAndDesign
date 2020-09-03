using System.ComponentModel;

namespace Common
{
	public interface IViewModel : INotifyPropertyChanged
	{
	}
	public interface IDynamicViewModel : IViewModel, IAmDirty
	{
		void OnInit();
		void OnDiscard();
		void OnSave();
	}
}
