using System.Drawing;
using System.Windows.Forms;

namespace MyApplication
{
	partial class UpdateProfileForm
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
			fullNameLabel = new Dtat.Windows.Forms.Label();
			fullNameTextBox = new Dtat.Windows.Forms.TextBox();
			descriptionLabel = new Dtat.Windows.Forms.Label();
			saveButton = new Dtat.Windows.Forms.Button();
			resetButton = new Dtat.Windows.Forms.Button();
			panel1 = new Dtat.Windows.Forms.Panel();
			descriptionTextBox = new Dtat.Windows.Forms.TextBox();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// fullNameLabel
			// 
			fullNameLabel.AutoSize = true;
			fullNameLabel.Location = new Point(12, 11);
			fullNameLabel.Name = "fullNameLabel";
			fullNameLabel.Size = new Size(76, 20);
			fullNameLabel.TabIndex = 0;
			fullNameLabel.Text = "&Full Name";
			// 
			// fullNameTextBox
			// 
			fullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			fullNameTextBox.Location = new Point(4, 8);
			fullNameTextBox.MaxLength = 20;
			fullNameTextBox.Name = "fullNameTextBox";
			fullNameTextBox.Size = new Size(377, 27);
			fullNameTextBox.TabIndex = 1;
			// 
			// descriptionLabel
			// 
			descriptionLabel.AutoSize = true;
			descriptionLabel.Location = new Point(12, 45);
			descriptionLabel.Name = "descriptionLabel";
			descriptionLabel.Size = new Size(85, 20);
			descriptionLabel.TabIndex = 2;
			descriptionLabel.Text = "&Description";
			// 
			// saveButton
			// 
			saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			saveButton.Location = new Point(4, 175);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(189, 29);
			saveButton.TabIndex = 4;
			saveButton.Text = "&Save";
			saveButton.UseVisualStyleBackColor = true;
			saveButton.Click += SaveButton_Click;
			// 
			// resetButton
			// 
			resetButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			resetButton.Location = new Point(199, 175);
			resetButton.Name = "resetButton";
			resetButton.Size = new Size(182, 29);
			resetButton.TabIndex = 5;
			resetButton.Text = "&Reset";
			resetButton.UseVisualStyleBackColor = true;
			resetButton.Click += ResetButton_Click;
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel1.Controls.Add(descriptionTextBox);
			panel1.Controls.Add(fullNameTextBox);
			panel1.Controls.Add(resetButton);
			panel1.Controls.Add(saveButton);
			panel1.Location = new Point(103, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(384, 223);
			panel1.TabIndex = 6;
			// 
			// descriptionTextBox
			// 
			descriptionTextBox.Location = new Point(4, 41);
			descriptionTextBox.Multiline = true;
			descriptionTextBox.Name = "descriptionTextBox";
			descriptionTextBox.ScrollBars = ScrollBars.Vertical;
			descriptionTextBox.Size = new Size(377, 128);
			descriptionTextBox.TabIndex = 6;
			// 
			// UpdateProfileForm
			// 
			AcceptButton = saveButton;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = resetButton;
			ClientSize = new Size(496, 230);
			Controls.Add(panel1);
			Controls.Add(descriptionLabel);
			Controls.Add(fullNameLabel);
			MaximizeBox = false;
			MaximumSize = new Size(800, 500);
			MinimizeBox = false;
			MinimumSize = new Size(514, 243);
			Name = "UpdateProfileForm";
			Text = "UpdateProfile";
			Load += UpdateProfileForm_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Dtat.Windows.Forms.Label fullNameLabel;
		private Dtat.Windows.Forms.TextBox fullNameTextBox;
		private Dtat.Windows.Forms.Label descriptionLabel;
		private Dtat.Windows.Forms.Button saveButton;
		private Dtat.Windows.Forms.Button resetButton;
		private Dtat.Windows.Forms.Panel panel1;
		private Dtat.Windows.Forms.TextBox descriptionTextBox;
	}
}