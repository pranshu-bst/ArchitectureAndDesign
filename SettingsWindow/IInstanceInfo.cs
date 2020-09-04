namespace SettingsWindow
{
	public interface IInstanceInfo
	{
		public string VmName { get; set; }
		public bool IsGuestBooted { get; set; }
	}
}
