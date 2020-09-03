namespace Common
{
	public interface IAmDirty
	{
		 bool IsDirty { get; set; }	// Checks if current viewmodel data is dirty

		 bool AreMyChildsDirty();		// checks if any child viewmodel data is dirty
	}
}
