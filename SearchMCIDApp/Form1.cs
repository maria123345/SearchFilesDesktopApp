namespace SearchMCIDApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> FileNames = new List<string>();
        private void btnupload_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Select File",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "Files (*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF;*.DOC;*.DOCX;*.XLS;*.XLSX;*.PDF;*.CSV)|" +
             "*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF;*.DOC;*.DOCX;*.XLS;*.XLSX;*.PDF;*.CSV|" +
             "All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LblSourcePath.Text = openFileDialog.FileName;
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string searchPath = TxtSearchDirectoryPath.Text;
                        if (Directory.Exists(searchPath))
                        {
                            var files = Directory.GetFiles(searchPath);
                            foreach (string file in files)
                            {

                                string data = "";
                                int lineNumber = 1;
                                StreamReader reader1 = new StreamReader(file);
                                while ((data = reader1.ReadLine()) != null && lineNumber <= 2)
                                {
                                    if (data.Contains(line))
                                    {
                                        FileNames.Add(file);
                                    }
                                    lineNumber++;
                                }


                            }
                        }
                    }
                }

                if (FileNames.Count > 0)
                {
                    FileNames = FileNames.Distinct().ToList();
                    string fileNames = "";
                    foreach (string file in FileNames)
                    {
                        fileNames += file;
                        fileNames += " ";
                    }
                    MessageBox.Show(fileNames);
                }
            }
        }
    }

}