using System.Drawing;
using System.Windows.Forms;

namespace MyApplication
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		//protected override void Dispose(bool disposing)
		//{
		//	if (disposing && (components != null))
		//	{
		//		components.Dispose();
		//	}
		//	base.Dispose(disposing);
		//}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			myMenuStrip = new MenuStrip();
			tollsToolStripMenuItem = new ToolStripMenuItem();
			updateProfileToolStripMenuItem = new ToolStripMenuItem();
			changePasswordToolStripMenuItem = new ToolStripMenuItem();
			seperatorToolStripMenuItem = new ToolStripSeparator();
			logoutToolStripMenuItem = new ToolStripMenuItem();
			exitToolStripMenuItem = new ToolStripMenuItem();
			adminToolStripMenuItem = new ToolStripMenuItem();
			usersToolStripMenuItem = new ToolStripMenuItem();
			myMenuStrip.SuspendLayout();
			SuspendLayout();
			// 
			// myMenuStrip
			// 
			myMenuStrip.ImageScalingSize = new Size(20, 20);
			myMenuStrip.Items.AddRange(new ToolStripItem[] { tollsToolStripMenuItem, adminToolStripMenuItem });
			myMenuStrip.Location = new Point(0, 0);
			myMenuStrip.Name = "myMenuStrip";
			myMenuStrip.Size = new Size(800, 28);
			myMenuStrip.TabIndex = 0;
			myMenuStrip.Text = "menuStrip1";
			// 
			// tollsToolStripMenuItem
			// 
			tollsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { updateProfileToolStripMenuItem, changePasswordToolStripMenuItem, seperatorToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
			tollsToolStripMenuItem.Name = "tollsToolStripMenuItem";
			tollsToolStripMenuItem.Size = new Size(70, 24);
			tollsToolStripMenuItem.Text = "&Setting";
			// 
			// updateProfileToolStripMenuItem
			// 
			updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
			updateProfileToolStripMenuItem.Size = new Size(207, 26);
			updateProfileToolStripMenuItem.Text = "&Update Profile";
			updateProfileToolStripMenuItem.Click += UpdateProfileToolStripMenuItem_Click;
			// 
			// changePasswordToolStripMenuItem
			// 
			changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
			changePasswordToolStripMenuItem.Size = new Size(207, 26);
			changePasswordToolStripMenuItem.Text = "&Change Password";
			changePasswordToolStripMenuItem.Click += ChangePasswordToolStripMenuItem_Click;
			// 
			// seperatorToolStripMenuItem
			// 
			seperatorToolStripMenuItem.Name = "seperatorToolStripMenuItem";
			seperatorToolStripMenuItem.Size = new Size(204, 6);
			// 
			// logoutToolStripMenuItem
			// 
			logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			logoutToolStripMenuItem.Size = new Size(207, 26);
			logoutToolStripMenuItem.Text = "&Logout";
			logoutToolStripMenuItem.Click += LogoutToolStripMenuItem_Click;
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(207, 26);
			exitToolStripMenuItem.Text = "&Exit";
			exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
			// 
			// adminToolStripMenuItem
			// 
			adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usersToolStripMenuItem });
			adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			adminToolStripMenuItem.Size = new Size(67, 24);
			adminToolStripMenuItem.Text = "&Admin";
			// 
			// usersToolStripMenuItem
			// 
			usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			usersToolStripMenuItem.Size = new Size(224, 26);
			usersToolStripMenuItem.Text = "&Users";
			usersToolStripMenuItem.Click += UsersToolStripMenuItem_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(800, 450);
			Controls.Add(myMenuStrip);
			IsMdiContainer = true;
			MainMenuStrip = myMenuStrip;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "User Management";
			WindowState = FormWindowState.Maximized;
			myMenuStrip.ResumeLayout(false);
			myMenuStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip myMenuStrip;
		private ToolStripMenuItem tollsToolStripMenuItem;
		private ToolStripMenuItem updateProfileToolStripMenuItem;
		private ToolStripMenuItem adminToolStripMenuItem;
		private ToolStripMenuItem logoutToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem usersToolStripMenuItem;
		private ToolStripMenuItem changePasswordToolStripMenuItem;
		private ToolStripSeparator seperatorToolStripMenuItem;
	}
}