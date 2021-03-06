﻿using System.Windows.Input;

using Common;

namespace BlueStacks.BlueStacksUI
{
	public class AboutSettingTabViewModel :ViewModel, IAboutSettingTabViewModel
	{
		public ICommand Website { get; set; }
		public ICommand Support { get; set; }
		public ICommand SupportEmail { get; set; }
		public ICommand TermsOfUse { get; set; }
	}
}
