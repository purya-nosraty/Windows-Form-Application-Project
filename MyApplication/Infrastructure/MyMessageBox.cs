using System.Linq;
using System.Windows.Forms;

namespace Infrastructure;

public static class MyMessageBox
{
	#region Constructor
	/// <summary>
	/// Constructor
	/// </summary>
	static MyMessageBox()
	{
	}
	#endregion /Constructor

	#region MessageBox

	#region YesNoMessageBox
	/// <summary>
	/// YesNoMessageBoxMethod
	/// </summary>
	/// <param name="text"></param>
	/// <param name="caption"></param>
	/// <returns></returns>
	public static DialogResult YesNoMessageBox(string text, string caption)
	{
		var result = System.Windows.Forms.MessageBox.Show(text: text,
		   caption: caption, icon: MessageBoxIcon.Question,
		   buttons: MessageBoxButtons.YesNo,
		   defaultButton: MessageBoxDefaultButton.Button2);

		return result;
	}
	#endregion /YesNoMessageBox

	#region ErrorMessageBox

	/// <summary>
	/// ErrorMessageBox(2arg)
	/// </summary>
	/// <param name="text"></param>
	/// <param name="caption"></param>
	/// <returns></returns>
	public static DialogResult ErrorMessageBox(string text, string caption)
	{
		var result = System.Windows.Forms.MessageBox.Show(text: text,
		   caption: caption, icon: MessageBoxIcon.Error,
		   buttons: MessageBoxButtons.OK);

		return result;
	}

	/// <summary>
	/// ErrorMessageBox
	/// </summary>
	/// <param name="text"></param>
	/// <returns></returns>
	public static DialogResult ErrorMessageBox(string text)
	{
		var result = System.Windows.Forms.MessageBox.Show(text: text,
		   caption: "Error", icon: MessageBoxIcon.Error,
		   buttons: MessageBoxButtons.OK);

		return result;
	}
	#endregion /ErrorMessageBox

	#region InformationMessageBox
	/// <summary>
	/// InformationMessageBox
	/// </summary>
	/// <param name="text"></param>
	/// <returns></returns>
	public static DialogResult InformationMessageBox(string text)
	{
		var result = System.Windows.Forms.MessageBox.Show(text: text,
		   caption: "Information", icon: MessageBoxIcon.Information,
		   buttons: MessageBoxButtons.OK);

		return result;
	}
	#endregion /InformationMessageBox

	#endregion /MessageBox
}