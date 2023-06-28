using System.Drawing;
using System.Windows.Forms;

namespace MyApplication
{
	partial class ChangePasswordForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			oldPasswordLabel = new Dtat.Windows.Forms.Label();
			oldPasswordTextBox = new Dtat.Windows.Forms.TextBox();
			newPasswordLabel = new Dtat.Windows.Forms.Label();
			newPasswordTextBox = new Dtat.Windows.Forms.TextBox();
			confirmNewPasswordLabel = new Dtat.Windows.Forms.Label();
			confirmNewPasswordTextBox = new Dtat.Windows.Forms.TextBox();
			changePasswordButtun = new Dtat.Windows.Forms.Button();
			resetButton = new Dtat.Windows.Forms.Button();
			SuspendLayout();
			// 
			// oldPasswordLabel
			// 
			oldPasswordLabel.AutoSize = true;
			oldPasswordLabel.Location = new Point(12, 15);
			oldPasswordLabel.Name = "oldPasswordLabel";
			oldPasswordLabel.Size = new Size(98, 20);
			oldPasswordLabel.TabIndex = 0;
			oldPasswordLabel.Text = "&Old Password";
			// 
			// oldPasswordTextBox
			// 
			oldPasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			oldPasswordTextBox.Location = new Point(179, 12);
			oldPasswordTextBox.MaxLength = 20;
			oldPasswordTextBox.Name = "oldPasswordTextBox";
			oldPasswordTextBox.Size = new Size(337, 27);
			oldPasswordTextBox.TabIndex = 1;
			oldPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// newPasswordLabel
			// 
			newPasswordLabel.AutoSize = true;
			newPasswordLabel.Location = new Point(12, 48);
			newPasswordLabel.Name = "newPasswordLabel";
			newPasswordLabel.Size = new Size(104, 20);
			newPasswordLabel.TabIndex = 2;
			newPasswordLabel.Text = "&New Password";
			// 
			// newPasswordTextBox
			// 
			newPasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			newPasswordTextBox.Location = new Point(179, 45);
			newPasswordTextBox.MaxLength = 20;
			newPasswordTextBox.Name = "newPasswordTextBox";
			newPasswordTextBox.Size = new Size(337, 27);
			newPasswordTextBox.TabIndex = 3;
			newPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// confirmNewPasswordLabel
			// 
			confirmNewPasswordLabel.AutoSize = true;
			confirmNewPasswordLabel.Location = new Point(12, 81);
			confirmNewPasswordLabel.Name = "confirmNewPasswordLabel";
			confirmNewPasswordLabel.Size = new Size(161, 20);
			confirmNewPasswordLabel.TabIndex = 4;
			confirmNewPasswordLabel.Text = "&Confirm New Password";
			// 
			// confirmNewPasswordTextBox
			// 
			confirmNewPasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			confirmNewPasswordTextBox.Location = new Point(179, 78);
			confirmNewPasswordTextBox.MaxLength = 20;
			confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
			confirmNewPasswordTextBox.Size = new Size(337, 27);
			confirmNewPasswordTextBox.TabIndex = 5;
			confirmNewPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// changePasswordButtun
			// 
			changePasswordButtun.Location = new Point(179, 111);
			changePasswordButtun.Name = "changePasswordButtun";
			changePasswordButtun.Size = new Size(161, 29);
			changePasswordButtun.TabIndex = 6;
			changePasswordButtun.Text = "Change &Password";
			changePasswordButtun.UseVisualStyleBackColor = true;
			changePasswordButtun.Click += ChangePasswordButtun_Click;
			// 
			// resetButton
			// 
			resetButton.Location = new Point(356, 111);
			resetButton.Name = "resetButton";
			resetButton.Size = new Size(160, 29);
			resetButton.TabIndex = 7;
			resetButton.Text = "&Reset";
			resetButton.UseVisualStyleBackColor = true;
			resetButton.Click += ResetButton_Click;
			// 
			// ChangePasswordForm
			// 
			AcceptButton = changePasswordButtun;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = resetButton;
			ClientSize = new Size(528, 153);
			Controls.Add(resetButton);
			Controls.Add(changePasswordButtun);
			Controls.Add(confirmNewPasswordTextBox);
			Controls.Add(confirmNewPasswordLabel);
			Controls.Add(newPasswordTextBox);
			Controls.Add(newPasswordLabel);
			Controls.Add(oldPasswordTextBox);
			Controls.Add(oldPasswordLabel);
			MaximizeBox = false;
			MaximumSize = new Size(546, 200);
			MinimizeBox = false;
			MinimumSize = new Size(546, 200);
			Name = "ChangePasswordForm";
			Text = "Change Password";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Dtat.Windows.Forms.Label oldPasswordLabel;
		private Dtat.Windows.Forms.TextBox oldPasswordTextBox;
		private Dtat.Windows.Forms.Label newPasswordLabel;
		private Dtat.Windows.Forms.TextBox newPasswordTextBox;
		private Dtat.Windows.Forms.Label confirmNewPasswordLabel;
		private Dtat.Windows.Forms.TextBox confirmNewPasswordTextBox;
		private Dtat.Windows.Forms.Button changePasswordButtun;
		private Dtat.Windows.Forms.Button resetButton;
	}
}