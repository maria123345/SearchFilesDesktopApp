using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchMCIDApps
{
    public partial class SearchFile : Form
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
        string number;
     


        List<string> FileNames = new List<string>();
        List<string> checkstring = new List<string>();
        public SearchFile()
        {
            InitializeComponent();        

            DateTime currentDate = DateTime.Today;
            // Your desired date to compare (set to today's date)
            DateTime selectedDate = currentDate;
            // Set the MaxDate property of the DateTimePicker control
            //TodateTime.Value =DateTime.Now;
            TodateTime.Value = selectedDate;
            TodateTime.MaxDate = selectedDate;

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

        private void btnSourceFile_Click(object sender, EventArgs e)
        {
            try
            {
                fromDate = FromdateTime.Value;
                toDate = TodateTime.Value;
                logger.Info("user upload file");
                openFileDialog = new OpenFileDialog

                {
                   // InitialDirectory = @"D:\",
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

        private void button2_Click(object sender, EventArgs e)
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
            dataTable.Columns.Add("Sno", typeof(string));
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
                            int Sno = 0;
                            while ((line = reader.ReadLine()) != null)
                            {
                               
                              
                               
                                string fileNames = "";
                                int count = 0;
                                //if (fileNames2) { }
                               
                              
                                //here we have to add the key and file names with comma,and counts
                                // row["MCID"] = line;
                                searchDirectoryPath = TxtSearchDirectoryPath.Text;
                              
                                number = line.Trim();
                          //  string abc=    checkstring.Where(s => s.Contains("abc")).ToString();
                                int chk  = checkstring.Where(x=>x.Contains(line)).ToList().Count;
                                if (chk>0)
                                {

                                }
                               else
                                {
                                    DataRow row = dataTable.NewRow();
                                    dataTable.Rows.Add(row);

                                    Sno = Sno + 1;
                                    row["Sno"] = Sno;
                                    row["MCID"] = number;
                                    checkstring.Add(number);
                                    //DateTime fileDate = searchDirectoryPath.LastWriteTime;
                                    // dataTable.Rows.Add(row);

                                    if (Directory.Exists(searchDirectoryPath))
                                    {
                                        var files = Directory.GetFiles(searchDirectoryPath);
                                        logger.Info($"files count in search directory : {files.Length}");

                                        foreach (string file in files)
                                        {
                                            fileInfo = new FileInfo(file);

                                            //  if (fileInfo.LastWriteTime >= fromDate && fileInfo.LastWriteTime <= toDate)
                                            if (true)
                                            {

                                                string data = "";
                                                int lineNumber = 1;
                                                StreamReader reader1 = new StreamReader(file);
                                                while ((data = reader1.ReadLine()) != null && lineNumber <= 2)
                                                {

                                                    if (data.Contains(line) && !string.IsNullOrWhiteSpace(line))
                                                    {
                                                        logger.Info($"File Matched : {line} ");
                                                        logger.Info($"File Matched : {file} ");
                                                        fileNames += Path.GetFileName(file);
                                                        fileNames += "\n";
                                                        count = count + 1;
                                                    
                                                        FileNames.Add(file);

                                                    }
                                                    lineNumber++;
                                                }

                                            }

                                        }
                                        row["FileName"] = fileNames;
                                        row["Status"] = count;
                                        fileNames = "";
                                        count = 0;
                                    }

                                    else
                                    {
                                        logger.Info("Search directory path does not exists.");
                                    }
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


                                //DataRow row = dataTable.NewRow();

                                //row["MCID"] = number;
                                //row["FileName"] = fileNames2;
                                ////if (fileNames2) { }
                                //row["Status"] = fileNames2.Count();
                                //dataTable.Rows.Add(row);
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
                    exLogger.Error(ex, $"Show:btnGo_Click");
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show(ErrorText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //old one
        //private void btnGo_Click(object sender, EventArgs e)
        //{
        //    DataTable dataTable = new DataTable();

        //    dataTable.Columns.Add("MCID", typeof(string));
        //    dataTable.Columns.Add("FileName", typeof(string));
        //    dataTable.Columns.Add("Status", typeof(string));
        //    dataTable.Clear();
        //    dataGridView1.DataSource = null;
        //    dataGridView1.Refresh();
        //    bool isValidInput = true;
        //    string ErrorText = "";
        //    if (string.IsNullOrEmpty(txtSourcePath.Text))
        //    {
        //        isValidInput = false;
        //        ErrorText += "Source file path is null.";
        //        logger.Error(ErrorText);
        //    }
        //    if (string.IsNullOrEmpty(TxtDestinationPath.Text))
        //    {
        //        isValidInput = false;
        //        ErrorText += "\nDestination file path is null.";
        //    }
        //    if (string.IsNullOrEmpty(TxtSearchDirectoryPath.Text))
        //    {
        //        isValidInput = false;
        //        ErrorText += "\nSearch Directory file path is null";
        //    }
        //    if (FromdateTime.Value > TodateTime.Value)
        //    {
        //        isValidInput = false;
        //        ErrorText += "\n From Date Must be less then equal to to date.";
        //    }
        //    if (isValidInput)
        //    {

        //        try
        //        {
        //            logger.Info("-------------Search Parameter ---------------");
        //            logger.Info($"From Date : {FromdateTime} ");
        //            logger.Info($"To Date : {TodateTime} ");
        //            logger.Info($" ");
        //            logger.Info("-------------Search Parameter ---------------");
        //            if (openFileDialog != null)
        //            {
        //                using (reader = new StreamReader(openFileDialog.FileName))
        //                {
        //                    string line;
        //                    while ((line = reader.ReadLine()) != null)
        //                    {
        //                      //here we have to add the key and file names with comma,and counts
        //                       // row["MCID"] = line;
        //                        searchDirectoryPath = TxtSearchDirectoryPath.Text;
        //                         number = line.Trim();
        //                        //DateTime fileDate = searchDirectoryPath.LastWriteTime;
        //                       // dataTable.Rows.Add(row);

        //                        if (Directory.Exists(searchDirectoryPath))
        //                        {
        //                            var files = Directory.GetFiles(searchDirectoryPath);
        //                            logger.Info($"files count in search directory : {files.Length}");

        //                            foreach (string file in files)
        //                            {
        //                                fileInfo = new FileInfo(file);

        //                              //  if (fileInfo.LastWriteTime >= fromDate && fileInfo.LastWriteTime <= toDate)
        //                                if (true)
        //                                    {

        //                                    string data = "";
        //                                    int lineNumber = 1;
        //                                    StreamReader reader1 = new StreamReader(file);
        //                                    while ((data = reader1.ReadLine()) != null && lineNumber <= 2)
        //                                    {

        //                                        if (data.Contains(line) && !string.IsNullOrWhiteSpace(line))
        //                                        {
        //                                            logger.Info($"File Matched : {line} ");
        //                                            logger.Info($"File Matched : {file} ");
        //                                            FileNames.Add(file);

        //                                        }
        //                                        lineNumber++;
        //                                    }
        //                                }


        //                            }

        //                        }

        //                        else
        //                        {
        //                            logger.Info("Search directory path does not exists.");
        //                        }
        //                    }
        //                }

        //                if (FileNames.Count > 0)
        //                {
        //                    logger.Info($"Total matched : {FileNames.Count} files .");
        //                    //  dataGridView1 = new DataGridView();
        //                    FileNames = FileNames.Distinct().ToList();
        //                    string fileNames = "";
        //                    string fileNames2 = "";
        //                    foreach (string file in FileNames)
        //                    {

        //                        fileNames2 += Path.GetFileName(file);
        //                        fileNames += Path.GetFileName(file);
        //                        fileNames += "\n";


        //                        DataRow row = dataTable.NewRow();

        //                        row["MCID"] = number;
        //                        row["FileName"] = fileNames2;
        //                        //if (fileNames2) { }
        //                        row["Status"] = fileNames2.Count();
        //                        dataTable.Rows.Add(row);
        //                        fileNames2 = "";

        //                    }
        //                    dataGridView1.DataSource = dataTable;

        //                    //MessageBox.Show(fileNames);

        //                    string NewDesignationPath = TxtDestinationPath.Text;
        //                    string FileName = DateTime.Now.ToString("ddMMyyyyHHmmssfff");


        //                    string filePath = Path.Combine(NewDesignationPath, FileName);
        //                    string NewFileName = "";

        //                    if (!File.Exists(filePath))
        //                    {
        //                        NewFileName = FileName;
        //                    }
        //                    else
        //                    {
        //                        NewFileName = filePath + "_New";
        //                    }
        //                    using (FileStream writer = File.Create(Path.Combine(NewDesignationPath, NewFileName)))
        //                    {
        //                        writer.Write(new UTF8Encoding(true).GetBytes(fileNames), 0, fileNames.Length);

        //                        // Get all matching files in the source directory
        //                        //string[] matchingFiles = Directory.GetFiles(searchDirectoryPath);

        //                        // Copy each matching file to the destination directory
        //                        foreach (string file in FileNames)
        //                        {

        //                            string subfilepath = Path.Combine(NewDesignationPath, Path.GetFileName(file));
        //                            if (!File.Exists(subfilepath))
        //                            {
        //                                File.Copy(file, Path.Combine(NewDesignationPath, Path.GetFileName(file)));
        //                                var FileContent = new UTF8Encoding(true).GetBytes(File.ReadAllText(file));
        //                            }
        //                            else
        //                            {

        //                                // File.Copy(file, Path.Combine(NewDesignationPath, Path.GetFileName(file)));
        //                                // var FileContent = new UTF8Encoding(true).GetBytes(File.ReadAllText(file));
        //                            }
        //                            // Write the file path to the text file
        //                        }
        //                        logger.Info("Matching files have been copied.");
        //                        // }
        //                    }
        //                }

        //                else
        //                {
        //                    logger.Info("No match files");
        //                }


        //            }
        //            else
        //            {
        //                MessageBox.Show("All path required");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            exLogger.Error(ex , $"Show:btnGo_Click");
        //            MessageBox.Show(ex.Message);
        //            throw;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show(ErrorText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

           
            dataTable.Columns.Add("FileName", typeof(string));
           // dataTable.Columns.Add("Status", typeof(string));
            DataRow row = dataTable.NewRow();
   
            row["FileName"] = "";
           // row["Status"] = "Yes";
            dataTable.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }
    }
}
