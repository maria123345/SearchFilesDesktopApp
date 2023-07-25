using System.Data;
using System.IO;
using System.Reflection;
using System.Text;
using NLog;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Metrics;

namespace SearchMCIDApp
{
    public partial class FileSearch : Form
    {
        private static readonly Logger logger = NLog.LogManager.GetLogger("event");
        private static readonly Logger exLogger = NLog.LogManager.GetLogger("exception");
        string searchDirectoryPath = "";
        string TextDestinationPath = "";
        DateTime fromDate = new DateTime(2023, 1, 1); // Replace with your desired from date
        DateTime toDate = new DateTime(2023, 12, 31); // Replace with your desired to date
        OpenFileDialog openFileDialog;
        FileInfo fileInfo;
        DateTime fileDate;
        StreamReader reader;

        List<string> FileNames = new List<string>();
        public FileSearch()
        {

            InitializeComponent();
            //this.dataGridView1 = new System.Windows.Forms.DataGridView();

            //// Set DataGridView properties
            //this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            //this.dataGridView1.Name = "dataGridView1";
            //this.dataGridView1.RowHeadersVisible = false;
            //this.dataGridView1.Size = new System.Drawing.Size(400, 200);
            //this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            //this.dataGridView1.TabIndex = 0;

            //// Add the DataGridView control to the form
            //this.Controls.Add(this.dataGridView1);
        }


        private void btnupload_Click(object sender, EventArgs e)
        {
            try
            {
                fromDate = FromdateTime.Value;
                toDate = TodateTime.Value;
                logger.Info("user upload file");
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
                    txtSourcePath.Text = openFileDialog.FileName;


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
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnDestinationPath_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("MCID", typeof(string));
            dataTable.Columns.Add("FileName", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            bool isValidInput = true;
            string ErrorText = "";
            if (string.IsNullOrEmpty(txtSourcePath.Text))
            {
                isValidInput = false;
                ErrorText += "Source file path is null.";
                logger.Error(ErrorText);
            }
            if (string.IsNullOrEmpty(TxtDestinationPath.Text))
            {
                isValidInput = false;
                ErrorText += "\nDestination file path is null.";
            }
            if (string.IsNullOrEmpty(TxtSearchDirectoryPath.Text))
            {
                isValidInput = false;
                ErrorText += "\nSearch Directory file path is null";
            }
            if (FromdateTime.Value > TodateTime.Value)
            {
                isValidInput = false;
                ErrorText += "\n From Date Must be less then equal to to date.";
            }
            if (isValidInput)
            {

                try
                {
                    logger.Info("-------------Search Parameter ---------------");
                    logger.Info($"From Date : {FromdateTime} ");
                    logger.Info($"To Date : {TodateTime} ");
                    logger.Info($" ");
                    logger.Info("-------------Search Parameter ---------------");
                    if (openFileDialog != null)
                    {
                        using (reader = new StreamReader(openFileDialog.FileName))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                searchDirectoryPath = TxtSearchDirectoryPath.Text;
                                //DateTime fileDate = searchDirectoryPath.LastWriteTime;


                                if (Directory.Exists(searchDirectoryPath))
                                {
                                    var files = Directory.GetFiles(searchDirectoryPath);
                                    logger.Info($"files count in search directory : {files.Length}");
                                    foreach (string file in files)
                                    {
                                        fileInfo = new FileInfo(file);

                                        if (fileInfo.LastWriteTime >= fromDate && fileInfo.LastWriteTime <= toDate)
                                        {

                                            string data = "";
                                            int lineNumber = 1;
                                            StreamReader reader1 = new StreamReader(file);
                                            while ((data = reader1.ReadLine()) != null && lineNumber <= 2)
                                            {

                                                if (data.Contains(line) && !string.IsNullOrWhiteSpace(line))
                                                {

                                                    logger.Info($"File Matched : {file} ");
                                                    FileNames.Add(file);

                                                }
                                                lineNumber++;
                                            }
                                        }


                                    }
                                }
                                else
                                {
                                    logger.Info("Search directory path does not exists.");
                                }
                            }
                        }

                        if (FileNames.Count > 0)
                        {
                            logger.Info($"Total matched : {FileNames.Count} files .");
                            //  dataGridView1 = new DataGridView();
                            FileNames = FileNames.Distinct().ToList();
                            string fileNames = "";
                            string fileNames2 = "";
                            foreach (string file in FileNames)
                            {

                                fileNames2 += Path.GetFileName(file);
                                fileNames += Path.GetFileName(file);
                                fileNames += "\n";


                                DataRow row = dataTable.NewRow();
                                row["MCID"] = "fd";
                                row["FileName"] = fileNames2;
                                row["Status"] = "Yes";

                                dataTable.Rows.Add(row);
                                fileNames2 = "";

                            }
                            dataGridView1.DataSource = dataTable;

                            //MessageBox.Show(fileNames);

                            string NewDesignationPath = TxtDestinationPath.Text;
                            string FileName = DateTime.Now.ToString("ddMMyyyyHHmmssfff");


                            string filePath = Path.Combine(NewDesignationPath, FileName);
                            string NewFileName = "";

                            if (!File.Exists(filePath))
                            {
                                NewFileName = FileName;
                            }
                            else
                            {
                                NewFileName = filePath + "_New";
                            }
                            using (FileStream writer = File.Create(Path.Combine(NewDesignationPath, NewFileName)))
                            {
                                writer.Write(new UTF8Encoding(true).GetBytes(fileNames), 0, fileNames.Length);

                                // Get all matching files in the source directory
                                //string[] matchingFiles = Directory.GetFiles(searchDirectoryPath);

                                // Copy each matching file to the destination directory
                                foreach (string file in FileNames)
                                {

                                    string subfilepath = Path.Combine(NewDesignationPath, Path.GetFileName(file));
                                    if (!File.Exists(subfilepath))
                                    {
                                        File.Copy(file, Path.Combine(NewDesignationPath, Path.GetFileName(file)));
                                        var FileContent = new UTF8Encoding(true).GetBytes(File.ReadAllText(file));
                                    }
                                    else
                                    {

                                        // File.Copy(file, Path.Combine(NewDesignationPath, Path.GetFileName(file)));
                                        // var FileContent = new UTF8Encoding(true).GetBytes(File.ReadAllText(file));
                                    }
                                    // Write the file path to the text file
                                }
                                logger.Info("Matching files have been copied.");
                                // }
                            }
                        }

                        else
                        {
                            logger.Info("No match files");
                        }


                    }
                    else
                    {
                        MessageBox.Show("All path required");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show(ErrorText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        private void btnrefresh_Click(object sender, EventArgs e)
        {
           
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("MCID", typeof(string));
            dataTable.Columns.Add("FileName", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            DataRow row = dataTable.NewRow();
            row["MCID"] = "fd";
            row["FileName"] = "";
            row["Status"] = "Yes";
            dataTable.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            
        }
    }
}


