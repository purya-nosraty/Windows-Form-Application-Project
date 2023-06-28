using System;
using System.Linq;
using System.Security.Policy;

namespace MyApplication.Admin;

public partial class UsersForm : Infrastructure.BaseForm
{
	#region Constructor
	public UsersForm()
	{
		InitializeComponent();
	}
	#endregion /Constructor

	#region Search
	private void SearchButton_Click(object sender, EventArgs e)
	{
		Search();
	}
	private void Search()
	{
		Persistence.DatabaseContext? databaseContext = null;

		try
		{
			databaseContext = new Persistence.DatabaseContext();

			fullNameTextBox.Text =
				Infrastructure.Utility
				.FixText(text: fullNameTextBox.Text);

			System.Collections.Generic.List<Domain.User>? users = null;

			users = databaseContext.Users
				.Where(current => current.FullName != null &&
				current.FullName.ToLower().Contains(fullNameTextBox.Text))
				.ToList();

			dataGridView.DataSource = users;
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
	#endregion /Search
}