namespace FILEsApp
{
    partial class Form1
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
            this.btnuploadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnuploadFile
            // 
            this.btnuploadFile.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnuploadFile.Location = new System.Drawing.Point(329, 104);
            this.btnuploadFile.Name = "btnuploadFile";
            this.btnuploadFile.Size = new System.Drawing.Size(75, 23);
            this.btnuploadFile.TabIndex = 1;
            this.btnuploadFile.Text = "upload File";
            this.btnuploadFile.UseVisualStyleBackColor = true;
            this.btnuploadFile.Click += new System.EventHandler(this.btnuploadFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnuploadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnuploadFile;
    }
}

