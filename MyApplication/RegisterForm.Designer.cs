using System.Drawing;
using System.Windows.Forms;

namespace MyApplication
{
	partial class RegisterForm
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
			fullNameLabel = new Dtat.Windows.Forms.Label();
			fullNameTextBox = new Dtat.Windows.Forms.TextBox();
			registerButton = new Dtat.Windows.Forms.Button();
			resetButton = new Dtat.Windows.Forms.Button();
			loginButton = new Dtat.Windows.Forms.Button();
			exitButton = new Dtat.Windows.Forms.Button();
			SuspendLayout();
			// 
			// usernameLabel
			// 
			usernameLabel.AutoSize = true;
			usernameLabel.Location = new Point(12, 15);
			usernameLabel.Name = "usernameLabel";
			usernameLabel.Size = new Size(75, 20);
			usernameLabel.TabIndex = 0;
			usernameLabel.Text = "&Username";
			// 
			// usernameTextBox
			// 
			usernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			usernameTextBox.Location = new Point(118, 12);
			usernameTextBox.MaxLength = 20;
			usernameTextBox.Name = "usernameTextBox";
			usernameTextBox.Size = new Size(394, 27);
			usernameTextBox.TabIndex = 1;
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Location = new Point(12, 48);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new Size(70, 20);
			passwordLabel.TabIndex = 2;
			passwordLabel.Text = "&Password";
			// 
			// passwordTextBox
			// 
			passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			passwordTextBox.Location = new Point(118, 45);
			passwordTextBox.MaxLength = 20;
			passwordTextBox.Name = "passwordTextBox";
			passwordTextBox.Size = new Size(394, 27);
			passwordTextBox.TabIndex = 3;
			passwordTextBox.UseSystemPasswordChar = true;
			// 
			// fullNameLabel
			// 
			fullNameLabel.AutoSize = true;
			fullNameLabel.Location = new Point(12, 81);
			fullNameLabel.Name = "fullNameLabel";
			fullNameLabel.Size = new Size(76, 20);
			fullNameLabel.TabIndex = 4;
			fullNameLabel.Text = "&Full Name";
			// 
			// fullNameTextBox
			// 
			fullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			fullNameTextBox.Location = new Point(118, 78);
			fullNameTextBox.MaxLength = 20;
			fullNameTextBox.Name = "fullNameTextBox";
			fullNameTextBox.Size = new Size(394, 27);
			fullNameTextBox.TabIndex = 5;
			// 
			// registerButton
			// 
			registerButton.Location = new Point(118, 111);
			registerButton.Name = "registerButton";
			registerButton.Size = new Size(94, 29);
			registerButton.TabIndex = 6;
			registerButton.Text = "Re&gister";
			registerButton.UseVisualStyleBackColor = true;
			registerButton.Click += RegisterButton_Click;
			// 
			// resetButton
			// 
			resetButton.Location = new Point(218, 111);
			resetButton.Name = "resetButton";
			resetButton.Size = new Size(94, 29);
			resetButton.TabIndex = 7;
			resetButton.Text = "&Reset";
			resetButton.UseVisualStyleBackColor = true;
			resetButton.Click += ResetButton_Click;
			// 
			// loginButton
			// 
			loginButton.Location = new Point(318, 111);
			loginButton.Name = "loginButton";
			loginButton.Size = new Size(94, 29);
			loginButton.TabIndex = 8;
			loginButton.Text = "&Login";
			loginButton.UseVisualStyleBackColor = true;
			loginButton.Click += LoginButton_Click;
			// 
			// exitButton
			// 
			exitButton.Location = new Point(418, 111);
			exitButton.Name = "exitButton";
			exitButton.Size = new Size(94, 29);
			exitButton.TabIndex = 9;
			exitButton.Text = "&Exit";
			exitButton.UseVisualStyleBackColor = true;
			exitButton.Click += ExitButton_Click;
			// 
			// RegisterForm
			// 
			AcceptButton = registerButton;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = resetButton;
			ClientSize = new Size(524, 154);
			Controls.Add(exitButton);
			Controls.Add(loginButton);
			Controls.Add(resetButton);
			Controls.Add(registerButton);
			Controls.Add(fullNameTextBox);
			Controls.Add(fullNameLabel);
			Controls.Add(passwordTextBox);
			Controls.Add(passwordLabel);
			Controls.Add(usernameTextBox);
			Controls.Add(usernameLabel);
			MaximizeBox = false;
			MaximumSize = new Size(542, 201);
			MinimizeBox = false;
			MinimumSize = new Size(542, 201);
			Name = "RegisterForm";
			Text = "Register";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Dtat.Windows.Forms.Label usernameLabel;
		private Dtat.Windows.Forms.TextBox usernameTextBox;
		private Dtat.Windows.Forms.Label passwordLabel;
		private Dtat.Windows.Forms.TextBox passwordTextBox;
		private Dtat.Windows.Forms.Label fullNameLabel;
		private Dtat.Windows.Forms.TextBox fullNameTextBox;
		private Dtat.Windows.Forms.Button registerButton;
		private Dtat.Windows.Forms.Button resetButton;
		private Dtat.Windows.Forms.Button loginButton;
		private Dtat.Windows.Forms.Button exitButton;
	}
}