using MyApplication.Admin;
using System;

namespace MyApplication;

internal static class Program
{
	[STAThread]
	static void Main()
	{
		// **************************************************
		var mainForm = new LoginForm();

		System.Windows.Forms.Application.Run(mainForm: mainForm);

		if (mainForm != null)
		{
			if (mainForm.IsDisposed == false)
			{
				mainForm.Dispose();
			}
		}
		// **************************************************
	}
}