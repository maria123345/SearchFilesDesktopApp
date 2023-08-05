namespace SearchMCIDApps
{
    partial class SearchFile
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
            this.btnSourceFile = new System.Windows.Forms.Button();
            this.btnSearchDirectoryPath = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.TxtSearchDirectoryPath = new System.Windows.Forms.TextBox();
            this.TxtDestinationPath = new System.Windows.Forms.TextBox();
            this.lblSearchSourcePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblFromDate = new System.Windows.Forms.Label();
            this.LblTo = new System.Windows.Forms.Label();
            this.FromdateTime = new System.Windows.Forms.DateTimePicker();
            this.TodateTime = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSourceFile
            // 
            this.btnSourceFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSourceFile.Location = new System.Drawing.Point(414, 82);
            this.btnSourceFile.Name = "btnSourceFile";
            this.btnSourceFile.Size = new System.Drawing.Size(144, 33);
            this.btnSourceFile.TabIndex = 0;
            this.btnSourceFile.Text = "Source File";
            this.btnSourceFile.UseVisualStyleBackColor = true;
            this.btnSourceFile.Click += new System.EventHandler(this.btnSourceFile_Click);
            // 
            // btnSearchDirectoryPath
            // 
            this.btnSearchDirectoryPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchDirectoryPath.Location = new System.Drawing.Point(414, 137);
            this.btnSearchDirectoryPath.Name = "btnSearchDirectoryPath";
            this.btnSearchDirectoryPath.Size = new System.Drawing.Size(144, 31);
            this.btnSearchDirectoryPath.TabIndex = 1;
            this.btnSearchDirectoryPath.Text = "Search Directory Path";
            this.btnSearchDirectoryPath.UseVisualStyleBackColor = true;
            this.btnSearchDirectoryPath.Click += new System.EventHandler(this.btnSearchDirectoryPath_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(414, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Source File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Enabled = false;
            this.txtSourcePath.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtSourcePath.Location = new System.Drawing.Point(172, 82);
            this.txtSourcePath.Multiline = true;
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.ReadOnly = true;
            this.txtSourcePath.Size = new System.Drawing.Size(212, 33);
            this.txtSourcePath.TabIndex = 3;
            this.txtSourcePath.Text = "Source Text File";
            // 
            // TxtSearchDirectoryPath
            // 
            this.TxtSearchDirectoryPath.Enabled = false;
            this.TxtSearchDirectoryPath.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtSearchDirectoryPath.Location = new System.Drawing.Point(172, 135);
            this.TxtSearchDirectoryPath.Multiline = true;
            this.TxtSearchDirectoryPath.Name = "TxtSearchDirectoryPath";
            this.TxtSearchDirectoryPath.ReadOnly = true;
            this.TxtSearchDirectoryPath.Size = new System.Drawing.Size(212, 33);
            this.TxtSearchDirectoryPath.TabIndex = 4;
            this.TxtSearchDirectoryPath.Text = "Search Directory Path";
            // 
            // TxtDestinationPath
            // 
            this.TxtDestinationPath.Enabled = false;
            this.TxtDestinationPath.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtDestinationPath.Location = new System.Drawing.Point(172, 187);
            this.TxtDestinationPath.Multiline = true;
            this.TxtDestinationPath.Name = "TxtDestinationPath";
            this.TxtDestinationPath.ReadOnly = true;
            this.TxtDestinationPath.Size = new System.Drawing.Size(212, 33);
            this.TxtDestinationPath.TabIndex = 5;
            this.TxtDestinationPath.Text = "Search Diestination Path";
            // 
            // lblSearchSourcePath
            // 
            this.lblSearchSourcePath.AutoSize = true;
            this.lblSearchSourcePath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSearchSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchSourcePath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSearchSourcePath.Location = new System.Drawing.Point(43, 90);
            this.lblSearchSourcePath.Name = "lblSearchSourcePath";
            this.lblSearchSourcePath.Size = new System.Drawing.Size(123, 15);
            this.lblSearchSourcePath.TabIndex = 6;
            this.lblSearchSourcePath.Text = "Search Source Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(43, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search Source Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(43, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search Source Path";
            // 
            // LblFromDate
            // 
            this.LblFromDate.AutoSize = true;
            this.LblFromDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFromDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblFromDate.Location = new System.Drawing.Point(43, 45);
            this.LblFromDate.Name = "LblFromDate";
            this.LblFromDate.Size = new System.Drawing.Size(75, 15);
            this.LblFromDate.TabIndex = 9;
            this.LblFromDate.Text = "From Date: ";
            // 
            // LblTo
            // 
            this.LblTo.AutoSize = true;
            this.LblTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTo.Location = new System.Drawing.Point(321, 41);
            this.LblTo.Name = "LblTo";
            this.LblTo.Size = new System.Drawing.Size(63, 15);
            this.LblTo.TabIndex = 10;
            this.LblTo.Text = "To Date: ";
            // 
            // FromdateTime
            // 
            this.FromdateTime.Location = new System.Drawing.Point(172, 40);
            this.FromdateTime.Name = "FromdateTime";
            this.FromdateTime.Size = new System.Drawing.Size(141, 20);
            this.FromdateTime.TabIndex = 11;
            // 
            // TodateTime
            // 
            this.TodateTime.Location = new System.Drawing.Point(414, 40);
            this.TodateTime.MaxDate = new System.DateTime(2023, 7, 27, 0, 0, 0, 0);
            this.TodateTime.Name = "TodateTime";
            this.TodateTime.Size = new System.Drawing.Size(144, 20);
            this.TodateTime.TabIndex = 12;
            this.TodateTime.Value = new System.DateTime(2023, 7, 27, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(43, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 165);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnGo
            // 
            this.btnGo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGo.Location = new System.Drawing.Point(90, 237);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(152, 23);
            this.btnGo.TabIndex = 14;
            this.btnGo.Text = "Serach Files";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnrefresh.Location = new System.Drawing.Point(355, 237);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(152, 23);
            this.btnrefresh.TabIndex = 15;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // SearchFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 441);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TodateTime);
            this.Controls.Add(this.FromdateTime);
            this.Controls.Add(this.LblTo);
            this.Controls.Add(this.LblFromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSearchSourcePath);
            this.Controls.Add(this.TxtDestinationPath);
            this.Controls.Add(this.TxtSearchDirectoryPath);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSearchDirectoryPath);
            this.Controls.Add(this.btnSourceFile);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "SearchFile";
            this.Text = "Search File";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSourceFile;
        private System.Windows.Forms.Button btnSearchDirectoryPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.TextBox TxtSearchDirectoryPath;
        private System.Windows.Forms.TextBox TxtDestinationPath;
        private System.Windows.Forms.Label lblSearchSourcePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblFromDate;
        private System.Windows.Forms.Label LblTo;
        private System.Windows.Forms.DateTimePicker FromdateTime;
        private System.Windows.Forms.DateTimePicker TodateTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnrefresh;
    }
}