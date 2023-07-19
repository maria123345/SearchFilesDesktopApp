using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SearchMCIDApp
{
    public partial class Form1 : Form
    {
        string searchDirectoryPath = "";
        string TextDestinationPath = "";
        DateTime fromDate = new DateTime(2023, 1, 1); // Replace with your desired from date
        DateTime toDate = new DateTime(2023, 12, 31); // Replace with your desired to date
        OpenFileDialog openFileDialog;
        public Form1()
        {
            InitializeComponent();
        }
        List<string> FileNames = new List<string>();

        private void btnupload_Click(object sender, EventArgs e)
         {
            try
            {
                fromDate = FromdateTime.Value;
                toDate = TodateTime.Value;
                openFileDialog = new OpenFileDialog

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
                            searchDirectoryPath = TxtSearchDirectoryPath.Text;
                            //DateTime fileDate = searchDirectoryPath.LastWriteTime;


                            if (Directory.Exists(searchDirectoryPath))
                            {
                                var files = Directory.GetFiles(searchDirectoryPath);
                                foreach (string file in files)
                                {
                                    FileInfo fileInfo = new FileInfo(file);
                                    if (fileInfo.LastWriteTime >= fromDate && fileInfo.LastWriteTime <= toDate)
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
                    }

                    if (FileNames.Count > 0)
                    {
                        FileNames = FileNames.Distinct().ToList();
                        string fileNames = "";
                        foreach (string file in FileNames)
                        {
                            fileNames += Path.GetFileName(file);
                            fileNames += "\n";
                        }
                        MessageBox.Show(fileNames);
                        // TextDestinationPath = TxtDestinationPath.Text;
                        string NewDesignationPath = TxtDestinationPath.Text;
                        string FileName = DateTime.Now.ToString("ddMMyyyyHHmmssfff");
                        using (FileStream writer = File.Create(Path.Combine(NewDesignationPath, FileName)))
                        {
                            writer.Write(new UTF8Encoding(true).GetBytes(fileNames), 0, fileNames.Length);

                            // Get all matching files in the source directory
                            //string[] matchingFiles = Directory.GetFiles(searchDirectoryPath);

                            // Copy each matching file to the destination directory
                            foreach (string file in FileNames)
                            {

                                File.Copy(file, Path.Combine(NewDesignationPath, Path.GetFileName(file)));
                                var FileContent = new UTF8Encoding(true).GetBytes(File.ReadAllText(file));
                                // Write the file path to the text file
                            }

                        }
                    }
                    Console.WriteLine("Matching files have been copied.");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnSearchDirectoryPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    TxtSearchDirectoryPath.Text = fbd.SelectedPath;

                }
            }
        }

        private void btnDestinationPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                  TxtDestinationPath.Text = fbd.SelectedPath;

                   
                }
            }

        }
    }
}


