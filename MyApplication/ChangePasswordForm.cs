using System;
using System.Linq;


namespace MyApplication;

public partial class ChangePasswordForm : Infrastructure.BaseForm
{
	#region Constructor
	/// <summary>
	/// Constructor
	/// </summary>
	public ChangePasswordForm()
	{
		InitializeComponent();
	}
	#endregion /Constructor

	#region ChangePasswordButtun
	private void ChangePasswordButtun_Click(object sender, EventArgs e)
	{
		if (Infrastructure.Utility.AuthenticatedUser == null)
		{
			System.Windows.Forms.Application.Exit();
			return;
		}

		Persistence.DatabaseContext? databaseContext = null;

		try
		{
			databaseContext =
				new Persistence.DatabaseContext();

			var currentUser =
				databaseContext.Users
				.Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
				.FirstOrDefault();

			if (currentUser == null)
			{
				System.Windows.Forms.Application.Exit();
				return;
			}
			if (currentUser.IsActive == false)
			{
				System.Windows.Forms.Application.Exit();
				return;
			}

			if (oldPasswordTextBox.Text != currentUser.Password)
			{
				Infrastructure.MyMessageBox.ErrorMessageBox("your password is not correct!");
				oldPasswordTextBox.Text = string.Empty;
				oldPasswordTextBox.Focus();

				return;
			}
			if (newPasswordTextBox.Text.Length < 8)
			{
				Infrastructure.MyMessageBox.ErrorMessageBox
					("The Password should be atleast 8 characters!");
				newPasswordTextBox.Text = string.Empty;
				confirmNewPasswordTextBox.Text = string.Empty;
				newPasswordTextBox.Focus();

				return;
			}
			if (newPasswordTextBox.Text == confirmNewPasswordTextBox.Text)
			{
				currentUser.Password = newPasswordTextBox.Text;
				Infrastructure.MyMessageBox.InformationMessageBox
				("your password changes successfully!");

				this.Close();
			}
			else
			{
				Infrastructure.MyMessageBox.ErrorMessageBox
					("your new password should be confirmed!");

				confirmNewPasswordTextBox.Text = string.Empty;
				confirmNewPasswordTextBox.Focus();
			}

			databaseContext.SaveChanges();
		}

		catch (Exception ex)
		{
			var errorMessage =
				$"ErrorMessage {ex.Message}";
		}

		finally
		{
			databaseContext?.Dispose();
		}
	}
	#endregion /ChangePasswordButtun

	#region ResetButton
	private void ResetButton_Click(object sender, EventArgs e)
	{
		oldPasswordTextBox.Text = string.Empty;
		newPasswordTextBox.Text = string.Empty;
		confirmNewPasswordTextBox.Text = string.Empty;

		oldPasswordTextBox.Focus();
	}
	#endregion /ResetButton
}
