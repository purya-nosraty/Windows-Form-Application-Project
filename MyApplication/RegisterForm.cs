using System;
using System.Linq;


namespace MyApplication;

public partial class RegisterForm : Infrastructure.BaseForm
{
	#region constructor
	/// <summary>
	/// Constructor
	/// </summary>
	public RegisterForm()
	{
		InitializeComponent();
	}
	#endregion /constructor

	#region Events
	#region Reset
	/// <summary>
	/// ResetMethod
	/// </summary>
	public void Reset()
	{
		usernameTextBox.Text = string.Empty;
		passwordTextBox.Text = string.Empty;
		fullNameTextBox.Text = string.Empty;
	}
	#endregion /Reset

	#region RegisterButton
	private void RegisterButton_Click(object sender, EventArgs e)
	{
		string username = usernameTextBox.Text;
		string password = passwordTextBox.Text;
		string fullName = fullNameTextBox.Text;

		username = Infrastructure.Utility.FixText(text: username);
		password = Infrastructure.Utility.FixText(text: password);
		fullName = Infrastructure.Utility.FixText(text: fullName);

		if (username == string.Empty || password == string.Empty)
		{
			Infrastructure.MyMessageBox
				.ErrorMessageBox(text: "Username and Password are required!");

			if (username == string.Empty)
			{
				usernameTextBox.Focus();
			}
			else
			{
				passwordTextBox.Focus();
			}

			return;
		}

		var errorMessage = string.Empty;

		if (username.Length < 6)
		{
			errorMessage =
				"Username must be at least 6 characters";
		}

		if (password.Length < 8)
		{
			if (errorMessage != string.Empty)
			{
				errorMessage +=
						System.Environment.NewLine;
			}

			errorMessage +=
				"Password must be at least 8 characters";
		}

		if (errorMessage != string.Empty)
		{
			Infrastructure.MyMessageBox.ErrorMessageBox(text: errorMessage);

			if (username.Length < 6)
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
				databaseContext.Users.
				Where(current => current.Username.ToLower() == username.ToLower())
				.FirstOrDefault();

			if (foundedUser != null)
			{
				Infrastructure.MyMessageBox
					.ErrorMessageBox(text: "the username is already exists!");

				usernameTextBox.Focus();

				return;
			}

			var newUser = new Domain.User(username: username, password: password)
			{
				IsActive = true,
				FullName = fullName,
			};

			databaseContext.Add(entity: newUser);
			databaseContext.SaveChanges();

			var message = $" User '{username}' registered successfully.";

			Infrastructure.MyMessageBox.InformationMessageBox(text: message);

			Reset();

			usernameTextBox.Focus();
		}

		catch (Exception ex)
		{
			Infrastructure.MyMessageBox.ErrorMessageBox(text: $"Error Message: {ex.Message}");
		}

		finally
		{
			databaseContext?.Dispose();
		}

	}
	#endregion /RegisterButton

	#region ResetButton
	private void ResetButton_Click(object sender, EventArgs e)
	{
		Reset();
	}
	#endregion /ResetButton

	#region LoginButton
	private void LoginButton_Click(object sender, EventArgs e)
	{
		LoginForm loginForm = new LoginForm();
		loginForm.Show();
		this.Close();
	}
	#endregion /LoginButton

	#region ExitButton
	private void ExitButton_Click(object sender, EventArgs e)
	{
		var result =
			Infrastructure.MyMessageBox.YesNoMessageBox
			(text: "Are you sure?",
			caption: "Exit");

		if (result == System.Windows.Forms.DialogResult.Yes)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
	#endregion /ExitButton
	#endregion Events
}
