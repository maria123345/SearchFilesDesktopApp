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
            FromdateTime = new DateTimePicker();
            TodateTime = new DateTimePicker();
            Lbl = new Label();
            LblTo = new Label();
            btnSearchDirectoryPath = new Button();
            btnDestinationPath = new Button();
            dataGridView1 = new DataGridView();
            FileName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnupload
            // 
            btnupload.Location = new Point(567, 89);
            btnupload.Name = "btnupload";
            btnupload.Size = new Size(174, 23);
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
            // FromdateTime
            // 
            FromdateTime.Location = new Point(167, 37);
            FromdateTime.Name = "FromdateTime";
            FromdateTime.Size = new Size(194, 23);
            FromdateTime.TabIndex = 6;
            // 
            // TodateTime
            // 
            TodateTime.Location = new Point(467, 35);
            TodateTime.Name = "TodateTime";
            TodateTime.Size = new Size(200, 23);
            TodateTime.TabIndex = 7;
            // 
            // Lbl
            // 
            Lbl.AutoSize = true;
            Lbl.Location = new Point(88, 41);
            Lbl.Name = "Lbl";
            Lbl.Size = new Size(35, 15);
            Lbl.TabIndex = 8;
            Lbl.Text = "From";
            // 
            // LblTo
            // 
            LblTo.AutoSize = true;
            LblTo.Location = new Point(396, 41);
            LblTo.Name = "LblTo";
            LblTo.Size = new Size(21, 15);
            LblTo.TabIndex = 9;
            LblTo.Text = "TO";
            // 
            // btnSearchDirectoryPath
            // 
            btnSearchDirectoryPath.Location = new Point(567, 161);
            btnSearchDirectoryPath.Name = "btnSearchDirectoryPath";
            btnSearchDirectoryPath.Size = new Size(174, 23);
            btnSearchDirectoryPath.TabIndex = 10;
            btnSearchDirectoryPath.Text = "Search Directory Path";
            btnSearchDirectoryPath.UseVisualStyleBackColor = true;
            btnSearchDirectoryPath.Click += btnSearchDirectoryPath_Click;
            // 
            // btnDestinationPath
            // 
            btnDestinationPath.Location = new Point(567, 247);
            btnDestinationPath.Name = "btnDestinationPath";
            btnDestinationPath.Size = new Size(174, 23);
            btnDestinationPath.TabIndex = 11;
            btnDestinationPath.Text = "Destination Path";
            btnDestinationPath.UseVisualStyleBackColor = true;
            btnDestinationPath.Click += btnDestinationPath_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FileName, Status });
            dataGridView1.Location = new Point(240, 314);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(501, 251);
            dataGridView1.TabIndex = 12;
            // 
            // FileName
            // 
            FileName.HeaderText = "FileName";
            FileName.Name = "FileName";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 592);
            Controls.Add(dataGridView1);
            Controls.Add(btnDestinationPath);
            Controls.Add(btnSearchDirectoryPath);
            Controls.Add(LblTo);
            Controls.Add(Lbl);
            Controls.Add(TodateTime);
            Controls.Add(FromdateTime);
            Controls.Add(LblSearchDestinationPath);
            Controls.Add(LblSearchDirectoryPath);
            Controls.Add(TxtDestinationPath);
            Controls.Add(TxtSearchDirectoryPath);
            Controls.Add(LblSourcePath);
            Controls.Add(btnupload);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DateTimePicker FromdateTime;
        private DateTimePicker TodateTime;
        private Label Lbl;
        private Label LblTo;
        private Button btnSearchDirectoryPath;
        private Button btnDestinationPath;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn Status;
    }
}