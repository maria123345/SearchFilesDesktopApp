using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FILEsApp
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void btnuploadFile_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.CheckFileExists = true;
            string textBox1 = openFileDialog.FileName;
            var image = new Image<Bgr, byte>(textBox1);
            Tesseract ocr = new Tesseract();
            ocr.SetImage(image);
            ocr.Recognize();

            string extractedText = ocr.GetUTF8Text();
        }
    }
}
