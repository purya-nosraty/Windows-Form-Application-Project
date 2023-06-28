using System.Drawing;
using System.Windows.Forms;

namespace MyApplication
{
	partial class LoginForm
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
			usernameLabel = new Dtat.Windows.Forms.Label();
			usernameTextBox = new Dtat.Windows.Forms.TextBox();
			passwordLabel = new Dtat.Windows.Forms.Label();
			passwordTextBox = new Dtat.Windows.Forms.TextBox();
			loginButton = new Dtat.Windows.Forms.Button();
			resetButton = new Dtat.Windows.Forms.Button();
			registerButton = new Dtat.Windows.Forms.Button();
			exitButton = new Dtat.Windows.Forms.Button();
			SuspendLayout();
			// 
			// usernameLabel
			// 
			usernameLabel.AutoSize = true;
			usernameLabel.Location = new Point(7, 15);
			usernameLabel.Name = "usernameLabel";
			usernameLabel.Size = new Size(75, 20);
			usernameLabel.TabIndex = 0;
			usernameLabel.Text = "&Username";
			// 
			// usernameTextBox
			// 
			usernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			usernameTextBox.Location = new Point(93, 12);
			usernameTextBox.MaxLength = 20;
			usernameTextBox.Name = "usernameTextBox";
			usernameTextBox.Size = new Size(394, 27);
			usernameTextBox.TabIndex = 1;
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Location = new Point(7, 48);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new Size(70, 20);
			passwordLabel.TabIndex = 2;
			passwordLabel.Text = "&Password";
			// 
			// passwordTextBox
			// 
			passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			passwordTextBox.Location = new Point(93, 45);
			passwordTextBox.MaxLength = 20;
			passwordTextBox.Name = "passwordTextBox";
			passwordTextBox.Size = new Size(394, 27);
			passwordTextBox.TabIndex = 3;
			passwordTextBox.UseSystemPasswordChar = true;
			// 
			// loginButton
			// 
			loginButton.Location = new Point(93, 78);
			loginButton.Name = "loginButton";
			loginButton.Size = new Size(94, 29);
			loginButton.TabIndex = 4;
			loginButton.Text = "&Login";
			loginButton.UseVisualStyleBackColor = true;
			loginButton.Click += LoginButton_Click;
			// 
			// resetButton
			// 
			resetButton.Location = new Point(193, 78);
			resetButton.Name = "resetButton";
			resetButton.Size = new Size(94, 29);
			resetButton.TabIndex = 5;
			resetButton.Text = "&Reset";
			resetButton.UseVisualStyleBackColor = true;
			resetButton.Click += ResetButton_Click;
			// 
			// registerButton
			// 
			registerButton.Location = new Point(293, 78);
			registerButton.Name = "registerButton";
			registerButton.Size = new Size(94, 29);
			registerButton.TabIndex = 6;
			registerButton.Text = "Re&gister";
			registerButton.UseVisualStyleBackColor = true;
			registerButton.Click += RegisterButton_Click;
			// 
			// exitButton
			// 
			exitButton.Location = new Point(393, 78);
			exitButton.Name = "exitButton";
			exitButton.Size = new Size(94, 29);
			exitButton.TabIndex = 7;
			exitButton.Text = "&Exit";
			exitButton.UseVisualStyleBackColor = true;
			exitButton.Click += ExitButton_Click;
			// 
			// LoginForm
			// 
			AcceptButton = loginButton;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = resetButton;
			ClientSize = new Size(499, 125);
			Controls.Add(exitButton);
			Controls.Add(registerButton);
			Controls.Add(resetButton);
			Controls.Add(loginButton);
			Controls.Add(passwordTextBox);
			Controls.Add(passwordLabel);
			Controls.Add(usernameTextBox);
			Controls.Add(usernameLabel);
			MaximizeBox = false;
			MaximumSize = new Size(517, 172);
			MinimizeBox = false;
			MinimumSize = new Size(517, 172);
			Name = "LoginForm";
			Text = "Login";
			Load += LoginForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Dtat.Windows.Forms.Label usernameLabel;
		private Dtat.Windows.Forms.Label passwordLabel;
		private Dtat.Windows.Forms.TextBox passwordTextBox;
		private Dtat.Windows.Forms.Button loginButton;
		private Dtat.Windows.Forms.Button resetButton;
		private Dtat.Windows.Forms.Button registerButton;
		private Dtat.Windows.Forms.Button exitButton;
		private Dtat.Windows.Forms.TextBox usernameTextBox;
	}
}