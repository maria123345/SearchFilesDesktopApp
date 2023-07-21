namespace SearchMCIDApp
{
    partial class FileSearch
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
            btnSourceFile = new Button();
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
            txtSourcePath = new TextBox();
            label1 = new Label();
            btnGo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSourceFile
            // 
            btnSourceFile.Location = new Point(464, 76);
            btnSourceFile.Name = "btnSourceFile";
            btnSourceFile.Size = new Size(143, 23);
            btnSourceFile.TabIndex = 0;
            btnSourceFile.Text = "Source File";
            btnSourceFile.UseVisualStyleBackColor = true;
            btnSourceFile.Click += btnupload_Click;
            // 
            // TxtSearchDirectoryPath
            // 
            TxtSearchDirectoryPath.Enabled = false;
            TxtSearchDirectoryPath.Location = new Point(215, 113);
            TxtSearchDirectoryPath.Multiline = true;
            TxtSearchDirectoryPath.Name = "TxtSearchDirectoryPath";
            TxtSearchDirectoryPath.PlaceholderText = "Search Directory Path";
            TxtSearchDirectoryPath.ReadOnly = true;
            TxtSearchDirectoryPath.RightToLeft = RightToLeft.No;
            TxtSearchDirectoryPath.Size = new Size(193, 30);
            TxtSearchDirectoryPath.TabIndex = 2;
            // 
            // TxtDestinationPath
            // 
            TxtDestinationPath.Enabled = false;
            TxtDestinationPath.Location = new Point(215, 149);
            TxtDestinationPath.Multiline = true;
            TxtDestinationPath.Name = "TxtDestinationPath";
            TxtDestinationPath.PlaceholderText = "Search Diestination Path";
            TxtDestinationPath.ReadOnly = true;
            TxtDestinationPath.Size = new Size(193, 31);
            TxtDestinationPath.TabIndex = 3;
            TxtDestinationPath.WordWrap = false;
            // 
            // LblSearchDirectoryPath
            // 
            LblSearchDirectoryPath.AutoSize = true;
            LblSearchDirectoryPath.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblSearchDirectoryPath.Location = new Point(57, 116);
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
            LblSearchDestinationPath.Location = new Point(57, 152);
            LblSearchDestinationPath.Name = "LblSearchDestinationPath";
            LblSearchDestinationPath.Padding = new Padding(3);
            LblSearchDestinationPath.Size = new Size(149, 21);
            LblSearchDestinationPath.TabIndex = 5;
            LblSearchDestinationPath.Text = "Search Diestination Path";
            // 
            // FromdateTime
            // 
            FromdateTime.Location = new Point(215, 41);
            FromdateTime.Name = "FromdateTime";
            FromdateTime.Size = new Size(128, 23);
            FromdateTime.TabIndex = 6;
            // 
            // TodateTime
            // 
            TodateTime.Location = new Point(464, 41);
            TodateTime.Name = "TodateTime";
            TodateTime.Size = new Size(146, 23);
            TodateTime.TabIndex = 7;
            // 
            // Lbl
            // 
            Lbl.AutoSize = true;
            Lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl.Location = new Point(61, 45);
            Lbl.Name = "Lbl";
            Lbl.Size = new Size(72, 15);
            Lbl.TabIndex = 8;
            Lbl.Text = "From Date: ";
            // 
            // LblTo
            // 
            LblTo.AutoSize = true;
            LblTo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblTo.Location = new Point(362, 45);
            LblTo.Name = "LblTo";
            LblTo.Size = new Size(56, 15);
            LblTo.TabIndex = 9;
            LblTo.Text = "To Date: ";
            // 
            // btnSearchDirectoryPath
            // 
            btnSearchDirectoryPath.Location = new Point(464, 114);
            btnSearchDirectoryPath.Name = "btnSearchDirectoryPath";
            btnSearchDirectoryPath.Size = new Size(143, 23);
            btnSearchDirectoryPath.TabIndex = 10;
            btnSearchDirectoryPath.Text = "Search Directory Path";
            btnSearchDirectoryPath.UseVisualStyleBackColor = true;
            btnSearchDirectoryPath.Click += btnSearchDirectoryPath_Click;
            // 
            // btnDestinationPath
            // 
            btnDestinationPath.Location = new Point(464, 152);
            btnDestinationPath.Name = "btnDestinationPath";
            btnDestinationPath.Size = new Size(143, 23);
            btnDestinationPath.TabIndex = 11;
            btnDestinationPath.Text = "Destination Path";
            btnDestinationPath.UseVisualStyleBackColor = true;
            btnDestinationPath.Click += btnDestinationPath_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(192, 255, 255);
            dataGridView1.Location = new Point(67, 245);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(540, 186);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtSourcePath
            // 
            txtSourcePath.Enabled = false;
            txtSourcePath.Location = new Point(215, 77);
            txtSourcePath.Multiline = true;
            txtSourcePath.Name = "txtSourcePath";
            txtSourcePath.PlaceholderText = "Search Source Path";
            txtSourcePath.ReadOnly = true;
            txtSourcePath.RightToLeft = RightToLeft.No;
            txtSourcePath.Size = new Size(193, 30);
            txtSourcePath.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 80);
            label1.Name = "label1";
            label1.Padding = new Padding(3);
            label1.Size = new Size(121, 21);
            label1.TabIndex = 14;
            label1.Text = "Search Source Path";
            // 
            // btnGo
            // 
            btnGo.Location = new Point(285, 207);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(143, 23);
            btnGo.TabIndex = 15;
            btnGo.Text = "Serach Files";
            btnGo.TextAlign = ContentAlignment.TopCenter;
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // FileSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 459);
            Controls.Add(btnGo);
            Controls.Add(label1);
            Controls.Add(txtSourcePath);
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
            Controls.Add(btnSourceFile);
            Name = "FileSearch";
            Text = "FileSearch";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSourceFile;
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
        private TextBox txtSourcePath;
        private Label label1;
        private Button btnGo;
    }
}