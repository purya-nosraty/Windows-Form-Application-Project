using MyApplication.Admin;
using System;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace MyApplication;

public partial class MainForm : Form
{
	#region Constructor
	/// <summary>
	/// Constructor
	/// </summary>
	public MainForm()
	{
		InitializeComponent();
	}
	#endregion /Constructor

	#region ToolStripMenuItem
	#region UpdateProfileForm
	/// <summary>
	/// UpdateProfileForm
	/// </summary>
	private UpdateProfileForm? UpdateProfileForm { get; set; }

	private void UpdateProfileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (UpdateProfileForm == null || UpdateProfileForm.IsDisposed)
		{
			UpdateProfileForm = new UpdateProfileForm();

			UpdateProfileForm.MdiParent = this;
		}

		UpdateProfileForm.Show();

	}
	#endregion /UpdateProfileForm

	#region ChangePasswordForm
	/// <summary>
	/// ChangePasswordForm
	/// </summary>
	private ChangePasswordForm? ChangePasswordForm { get; set; }

	private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ChangePasswordForm == null || ChangePasswordForm.IsDisposed)
		{
			ChangePasswordForm = new ChangePasswordForm();

			ChangePasswordForm.MdiParent = this;
		}

		ChangePasswordForm.Show();
	}
	#endregion /ChangePasswordForm

	#region Logout

	/// <summary>
	/// Logout
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		var result = Infrastructure.MyMessageBox
			.YesNoMessageBox(text: "Are you sure?", caption: "Logout");

		if (result == DialogResult.Yes)
		{
			this.Close();

			var loginForm = new LoginForm();
			loginForm.Show();
		}
	}
	#endregion /Logout

	#region Exit
	/// <summary>
	/// Exit
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		var result =
			Infrastructure.MyMessageBox.YesNoMessageBox
				(text: "Are you sure?", caption: "Exit");

		if (result == DialogResult.Yes)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
	#endregion /Exit
	#endregion /ToolStripMenuItem

	#region UsersToolStripMenuItem
	private UsersForm? UsersForm { get; set; }
	private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Infrastructure.Utility.AuthenticatedUser.IsAdmin == true)
		{
			if (UsersForm == null || UsersForm.IsDisposed)
			{
				UsersForm = new UsersForm();
				UsersForm.MdiParent = this;
			}
			UsersForm.Show();
		}
		else
		{
			var message =
				"This Item is just for Admins";

			Infrastructure.MyMessageBox.ErrorMessageBox(message);
		}
	}
	#endregion /UsersToolStripMenuItem
}
