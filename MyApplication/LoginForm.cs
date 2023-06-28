using System;
using System.Linq;

namespace MyApplication;

public partial class LoginForm : Infrastructure.BaseForm
{
	#region Constructors
	/// <summary>
	/// Constructors
	/// </summary>
	public LoginForm()
	{
		InitializeComponent();
	}
	#endregion /Constructors

	#region Events
	#region FormLoad
	private void LoginForm_Load(object sender, EventArgs e)
	{
		Persistence.DatabaseContext? databaseContext = null;

		try
		{
			databaseContext =
				new Persistence.DatabaseContext();
		}
		catch (Exception ex)
		{
			var errorMessage =
				$"Error Message: {ex.Message}";

			Infrastructure.MyMessageBox.ErrorMessageBox(text: errorMessage);
		}
		finally
		{
			databaseContext?.Dispose();
		}
	}
	#endregion /FormLoad

	#region ResetMethod
	/// <summary>
	/// ResetMethod
	/// </summary>
	public void Reset()
	{
		usernameTextBox.Text = string.Empty;
		passwordTextBox.Text = string.Empty;
	}
	#endregion /ResetMethod

	#region LoginButtun
	private void LoginButton_Click(object sender, EventArgs e)
	{
		usernameTextBox.Text =
			Infrastructure.Utility
			.FixText(text: usernameTextBox.Text);

		passwordTextBox.Text =
			Infrastructure.Utility
			.FixText(text: passwordTextBox.Text);

		if (usernameTextBox.Text == string.Empty || passwordTextBox.Text == string.Empty)
		{
			var errorMessage =
				"Username and Password are required!";

			Infrastructure.MyMessageBox.ErrorMessageBox(text: errorMessage);

			if (usernameTextBox.Text == string.Empty)
			{
				usernameTextBox.Focus();
			}
			else
			{
				passwordTextBox.Focus();
			}

			return;
		}

		Persistence.DatabaseContext? databaseContext = null;

		try
		{
			databaseContext =
				new Persistence.DatabaseContext();

			var foundedUser =
				databaseContext.Users
				.Where(current => current.Username.ToLower() == usernameTextBox.Text.ToLower())
				.FirstOrDefault();

			if (foundedUser == null)
			{
				var errorMessage =
					"Username and/or Password is not correct!";

				Infrastructure.MyMessageBox.ErrorMessageBox(text: errorMessage);

				usernameTextBox.Focus();

				return;
			}

			if (string.Compare(foundedUser.Password,
				passwordTextBox.Text, ignoreCase: false) != 0)
			{
				var errorMessage =
					"Username and/or Password is not correct!";

				Infrastructure.MyMessageBox.ErrorMessageBox(text: errorMessage);

				usernameTextBox.Focus();

				return;
			}

			if (foundedUser.IsActive == false)
			{
				var errorMessage =
					"You can not login right now! Please contact support.";

				Infrastructure.MyMessageBox.ErrorMessageBox(text: errorMessage);

				usernameTextBox.Focus();

				return;
			}

			Infrastructure.Utility.AuthenticatedUser = foundedUser;
		}

		catch (Exception ex)
		{
			var errorMessage =
				$"ErrorMessage:{ex.Message}";

			Infrastructure.MyMessageBox.ErrorMessageBox(text: errorMessage);
		}

		finally
		{
			databaseContext?.Dispose();
		}

		MainForm mainForm = new MainForm();
		mainForm.Show();
		this.Hide();
	}
	#endregion /LoginButtun

	#region ResetButtun
	private void ResetButton_Click(object sender, EventArgs e)
	{
		Reset();
	}
	#endregion /ResetButtun

	#region RegisterButton
	private void RegisterButton_Click(object sender, EventArgs e)
	{
		RegisterForm registerForm = new RegisterForm();
		registerForm.Show();
		this.Hide();
	}
	#endregion /RegisterButton

	#region ExitButton
	private void ExitButton_Click(object sender, EventArgs e)
	{
		var result =
			Infrastructure.MyMessageBox.YesNoMessageBox(text: "Are you sure?",
			caption: "Exit");

		if (result == System.Windows.Forms.DialogResult.Yes)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
	#endregion /ExitButton
	#endregion /Events
}
