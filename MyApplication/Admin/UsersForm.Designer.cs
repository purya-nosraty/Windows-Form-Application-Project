namespace MyApplication.Admin
{
	partial class UsersForm
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
			searchButton = new Dtat.Windows.Forms.Button();
			dataGridView = new Dtat.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
			SuspendLayout();
			// 
			// fullNameLabel
			// 
			fullNameLabel.AutoSize = true;
			fullNameLabel.Location = new System.Drawing.Point(12, 15);
			fullNameLabel.Name = "fullNameLabel";
			fullNameLabel.Size = new System.Drawing.Size(76, 20);
			fullNameLabel.TabIndex = 0;
			fullNameLabel.Text = "&Full Name";
			// 
			// fullNameTextBox
			// 
			fullNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			fullNameTextBox.Location = new System.Drawing.Point(118, 12);
			fullNameTextBox.MaxLength = 20;
			fullNameTextBox.Name = "fullNameTextBox";
			fullNameTextBox.Size = new System.Drawing.Size(454, 27);
			fullNameTextBox.TabIndex = 1;
			// 
			// searchButton
			// 
			searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			searchButton.Location = new System.Drawing.Point(118, 45);
			searchButton.Name = "searchButton";
			searchButton.Size = new System.Drawing.Size(454, 29);
			searchButton.TabIndex = 2;
			searchButton.Text = "&Search";
			searchButton.UseVisualStyleBackColor = true;
			searchButton.Click += SearchButton_Click;
			// 
			// dataGridView
			// 
			dataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView.Location = new System.Drawing.Point(0, 92);
			dataGridView.Name = "dataGridView";
			dataGridView.RowHeadersWidth = 51;
			dataGridView.RowTemplate.Height = 29;
			dataGridView.Size = new System.Drawing.Size(584, 253);
			dataGridView.TabIndex = 3;
			// 
			// UsersForm
			// 
			AcceptButton = searchButton;
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(584, 345);
			Controls.Add(dataGridView);
			Controls.Add(searchButton);
			Controls.Add(fullNameTextBox);
			Controls.Add(fullNameLabel);
			MinimumSize = new System.Drawing.Size(602, 392);
			Name = "UsersForm";
			Text = "Users";
			((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Dtat.Windows.Forms.Label fullNameLabel;
		private Dtat.Windows.Forms.TextBox fullNameTextBox;
		private Dtat.Windows.Forms.Button searchButton;
		private Dtat.Windows.Forms.DataGridView dataGridView;
	}
}