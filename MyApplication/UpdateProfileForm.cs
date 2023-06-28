using System;
using System.Linq;

namespace MyApplication;

public partial class UpdateProfileForm : Infrastructure.BaseForm
{
	#region Constructor
	/// <summary>
	/// Constructor
	/// </summary>
	public UpdateProfileForm()
	{
		InitializeComponent();
	}
	#endregion /Constructor

	#region UpdateProfileForm_Load
	private void UpdateProfileForm_Load(object sender, EventArgs e)
	{
		ResetForm();
	}
	#endregion /UpdateProfileForm_Load

	#region ResetButton
	private void ResetButton_Click(object sender, EventArgs e)
	{
		ResetForm();
	}
	#endregion /ResetButton

	#region ResetForm
	/// <summary>
	/// ResetMethod
	/// </summary>
	private void ResetForm()
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

			fullNameTextBox.Text = currentUser.FullName;
			descriptionTextBox.Text = currentUser.Description;
		}

		catch (Exception ex)
		{
			var errorMessage =
				$"ErrorMessage{ex.Message}";

			Infrastructure.MyMessageBox.ErrorMessageBox(errorMessage);
		}

		finally
		{
			databaseContext?.Dispose();
		}
	}
	#endregion /ResetForm

	#region SaveButton
	private void SaveButton_Click(object sender, EventArgs e)
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

			currentUser.FullName = fullNameTextBox.Text;
			currentUser.Description = descriptionTextBox.Text;

			databaseContext.SaveChanges();

			Infrastructure.MyMessageBox.InformationMessageBox("your profile updated successfully");
		}

		catch (Exception ex)
		{
			var errorMessage =
				$"ErrorMessage{ex.Message}";

			Infrastructure.MyMessageBox.ErrorMessageBox(errorMessage);
		}

		finally
		{
			databaseContext?.Dispose();
		}

		this.Close();
	}
	#endregion SaveButton
}