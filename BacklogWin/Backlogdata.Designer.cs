namespace BacklogWin
{
    partial class BacklogForm
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
            this.BacklogdataGridView = new System.Windows.Forms.DataGridView();
            this.MessageTypecomboBox = new System.Windows.Forms.ComboBox();
            this.MessageRequestTypecomboBox = new System.Windows.Forms.ComboBox();
            this.MessageStatuscomboBox = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.MessageStatusIDlbl = new System.Windows.Forms.Label();
            this.MessageRequestTypelbl = new System.Windows.Forms.Label();
            this.MessageTypelbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tolbl = new System.Windows.Forms.Label();
            this.Fromlbl = new System.Windows.Forms.Label();
            this.btnstatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BacklogdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BacklogdataGridView
            // 
            this.BacklogdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BacklogdataGridView.Location = new System.Drawing.Point(39, 98);
            this.BacklogdataGridView.Name = "BacklogdataGridView";
            this.BacklogdataGridView.Size = new System.Drawing.Size(1136, 441);
            this.BacklogdataGridView.TabIndex = 4;
            // 
            // MessageTypecomboBox
            // 
            this.MessageTypecomboBox.FormattingEnabled = true;
            this.MessageTypecomboBox.Location = new System.Drawing.Point(425, 47);
            this.MessageTypecomboBox.Name = "MessageTypecomboBox";
            this.MessageTypecomboBox.Size = new System.Drawing.Size(121, 21);
            this.MessageTypecomboBox.TabIndex = 9;
            // 
            // MessageRequestTypecomboBox
            // 
            this.MessageRequestTypecomboBox.FormattingEnabled = true;
            this.MessageRequestTypecomboBox.Location = new System.Drawing.Point(262, 47);
            this.MessageRequestTypecomboBox.Name = "MessageRequestTypecomboBox";
            this.MessageRequestTypecomboBox.Size = new System.Drawing.Size(121, 21);
            this.MessageRequestTypecomboBox.TabIndex = 8;
            // 
            // MessageStatuscomboBox
            // 
            this.MessageStatuscomboBox.FormattingEnabled = true;
            this.MessageStatuscomboBox.Location = new System.Drawing.Point(101, 47);
            this.MessageStatuscomboBox.Name = "MessageStatuscomboBox";
            this.MessageStatuscomboBox.Size = new System.Drawing.Size(121, 21);
            this.MessageStatuscomboBox.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1074, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 21);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // MessageStatusIDlbl
            // 
            this.MessageStatusIDlbl.AutoSize = true;
            this.MessageStatusIDlbl.Location = new System.Drawing.Point(98, 31);
            this.MessageStatusIDlbl.Name = "MessageStatusIDlbl";
            this.MessageStatusIDlbl.Size = new System.Drawing.Size(97, 13);
            this.MessageStatusIDlbl.TabIndex = 10;
            this.MessageStatusIDlbl.Text = "Message Status ID";
            // 
            // MessageRequestTypelbl
            // 
            this.MessageRequestTypelbl.AutoSize = true;
            this.MessageRequestTypelbl.Location = new System.Drawing.Point(263, 31);
            this.MessageRequestTypelbl.Name = "MessageRequestTypelbl";
            this.MessageRequestTypelbl.Size = new System.Drawing.Size(120, 13);
            this.MessageRequestTypelbl.TabIndex = 11;
            this.MessageRequestTypelbl.Text = "Message Request Type";
            // 
            // MessageTypelbl
            // 
            this.MessageTypelbl.AutoSize = true;
            this.MessageTypelbl.Location = new System.Drawing.Point(422, 31);
            this.MessageTypelbl.Name = "MessageTypelbl";
            this.MessageTypelbl.Size = new System.Drawing.Size(77, 13);
            this.MessageTypelbl.TabIndex = 12;
            this.MessageTypelbl.Text = "Message Type";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(599, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(852, 48);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // tolbl
            // 
            this.tolbl.AutoSize = true;
            this.tolbl.Location = new System.Drawing.Point(552, 48);
            this.tolbl.Name = "tolbl";
            this.tolbl.Size = new System.Drawing.Size(22, 13);
            this.tolbl.TabIndex = 15;
            this.tolbl.Text = "TO";
            // 
            // Fromlbl
            // 
            this.Fromlbl.AutoSize = true;
            this.Fromlbl.Location = new System.Drawing.Point(801, 50);
            this.Fromlbl.Name = "Fromlbl";
            this.Fromlbl.Size = new System.Drawing.Size(30, 13);
            this.Fromlbl.TabIndex = 16;
            this.Fromlbl.Text = "From";
            // 
            // btnstatus
            // 
            this.btnstatus.Location = new System.Drawing.Point(68, 545);
            this.btnstatus.Name = "btnstatus";
            this.btnstatus.Size = new System.Drawing.Size(110, 23);
            this.btnstatus.TabIndex = 17;
            this.btnstatus.Text = "change Status";
            this.btnstatus.UseVisualStyleBackColor = true;
            this.btnstatus.Click += new System.EventHandler(this.btnstatus_Click);
            // 
            // BacklogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 646);
            this.Controls.Add(this.btnstatus);
            this.Controls.Add(this.Fromlbl);
            this.Controls.Add(this.tolbl);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.MessageTypelbl);
            this.Controls.Add(this.MessageRequestTypelbl);
            this.Controls.Add(this.MessageStatusIDlbl);
            this.Controls.Add(this.MessageTypecomboBox);
            this.Controls.Add(this.MessageRequestTypecomboBox);
            this.Controls.Add(this.MessageStatuscomboBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.BacklogdataGridView);
            this.Name = "BacklogForm";
            this.Text = "BackLog";
            ((System.ComponentModel.ISupportInitialize)(this.BacklogdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView BacklogdataGridView;
        private System.Windows.Forms.ComboBox MessageTypecomboBox;
        private System.Windows.Forms.ComboBox MessageRequestTypecomboBox;
        private System.Windows.Forms.ComboBox MessageStatuscomboBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label MessageStatusIDlbl;
        private System.Windows.Forms.Label MessageRequestTypelbl;
        private System.Windows.Forms.Label MessageTypelbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label tolbl;
        private System.Windows.Forms.Label Fromlbl;
        private System.Windows.Forms.Button btnstatus;
    }
}

