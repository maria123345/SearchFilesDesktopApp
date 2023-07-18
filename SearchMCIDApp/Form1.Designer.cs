namespace SearchMCIDApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnupload = new Button();
            LblSourcePath = new Label();
            TxtSearchDirectoryPath = new TextBox();
            TxtDestinationPath = new TextBox();
            LblSearchDirectoryPath = new Label();
            LblSearchDestinationPath = new Label();
            SuspendLayout();
            // 
            // btnupload
            // 
            btnupload.Location = new Point(467, 85);
            btnupload.Name = "btnupload";
            btnupload.Size = new Size(75, 23);
            btnupload.TabIndex = 0;
            btnupload.Text = "upload file";
            btnupload.UseVisualStyleBackColor = true;
            btnupload.Click += btnupload_Click;
            // 
            // LblSourcePath
            // 
            LblSourcePath.AutoSize = true;
            LblSourcePath.Location = new Point(215, 93);
            LblSourcePath.Name = "LblSourcePath";
            LblSourcePath.Size = new Size(0, 15);
            LblSourcePath.TabIndex = 1;
            // 
            // TxtSearchDirectoryPath
            // 
            TxtSearchDirectoryPath.Location = new Point(349, 156);
            TxtSearchDirectoryPath.Multiline = true;
            TxtSearchDirectoryPath.Name = "TxtSearchDirectoryPath";
            TxtSearchDirectoryPath.Size = new Size(193, 30);
            TxtSearchDirectoryPath.TabIndex = 2;
            TxtSearchDirectoryPath.Text = "Search Directory Path";
            // 
            // TxtDestinationPath
            // 
            TxtDestinationPath.Location = new Point(346, 244);
            TxtDestinationPath.Multiline = true;
            TxtDestinationPath.Name = "TxtDestinationPath";
            TxtDestinationPath.Size = new Size(197, 31);
            TxtDestinationPath.TabIndex = 3;
            TxtDestinationPath.Text = "Search Diestination Path";
            // 
            // LblSearchDirectoryPath
            // 
            LblSearchDirectoryPath.AutoSize = true;
            LblSearchDirectoryPath.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblSearchDirectoryPath.Location = new Point(191, 159);
            LblSearchDirectoryPath.Name = "LblSearchDirectoryPath";
            LblSearchDirectoryPath.Padding = new Padding(3);
            LblSearchDirectoryPath.Size = new Size(135, 21);
            LblSearchDirectoryPath.TabIndex = 4;
            LblSearchDirectoryPath.Text = "Search Directory Path";
            // 
            // LblSearchDestinationPath
            // 
            LblSearchDestinationPath.AutoSize = true;
            LblSearchDestinationPath.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblSearchDestinationPath.Location = new Point(191, 247);
            LblSearchDestinationPath.Name = "LblSearchDestinationPath";
            LblSearchDestinationPath.Padding = new Padding(3);
            LblSearchDestinationPath.Size = new Size(149, 21);
            LblSearchDestinationPath.TabIndex = 5;
            LblSearchDestinationPath.Text = "Search Diestination Path";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblSearchDestinationPath);
            Controls.Add(LblSearchDirectoryPath);
            Controls.Add(TxtDestinationPath);
            Controls.Add(TxtSearchDirectoryPath);
            Controls.Add(LblSourcePath);
            Controls.Add(btnupload);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnupload;
        private Label LblSourcePath;
        private TextBox TxtSearchDirectoryPath;
        private TextBox TxtDestinationPath;
        private Label LblSearchDirectoryPath;
        private Label LblSearchDestinationPath;
    }
}