using NLog;
using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BacklogWin
{
    public partial class BacklogForm : Form
    {
        private static readonly Logger logger = NLog.LogManager.GetLogger("event");
        private static readonly Logger exLogger = NLog.LogManager.GetLogger("exception");
        public BacklogForm()
        {
            InitializeComponent();

            BacklogWin.BusinessLogic.BAL bAL = new BacklogWin.BusinessLogic.BAL();
            DataSet ds = new DataSet();
            ds = bAL.GetMessageStatus();

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            if (ds.Tables[0].Rows.Count > 0)  
           
                dt1 = ds.Tables[0];
           
            if (ds.Tables[1].Rows.Count > 0)
            {
                dt2 = ds.Tables[1];
                logger.Info(dt1.TableName);


            }

            MessageStatuscomboBox.DataSource = dt1.DefaultView;
            //MessageStatuscomboBox.DisplayMember = "MessageStatus";
            MessageStatuscomboBox.DisplayMember = "MessageStatusID";
            MessageStatuscomboBox.BindingContext = this.BindingContext;
            MessageStatuscomboBox.SelectedIndex = 0;
            MessageTypecomboBox.DataSource = dt2.DefaultView;
            //MessageStatuscomboBox.DisplayMember = "MessageStatus";
            MessageTypecomboBox.DisplayMember = "MessageTypeName";
            MessageTypecomboBox.BindingContext = this.BindingContext;

            //GetMessageType();
            GetMessageRequestType();
         


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            


        }

        public void GetMessageType()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            //dt.Columns.Add("MessageTypeID");
            //dt.Columns.Add("MessageTypeName");
            //DataRow _ravi = dt.NewRow();
            //_ravi["MessageTypeID"] = 1;
            //_ravi["MessageTypeName"] = "ref";
            //dt.Rows.Add(_ravi);

            //_ravi = dt.NewRow();
            //_ravi["MessageTypeID"] = 2;
            //_ravi["MessageTypeName"] = "oru";
            //dt.Rows.Add(_ravi);

            //_ravi = dt.NewRow();
            //_ravi["MessageTypeID"] = 3;
            //_ravi["MessageTypeName"] = "mail";
            //dt.Rows.Add(_ravi);

            //_ravi = dt.NewRow();
            //_ravi["MessageTypeID"] = 4;
            //_ravi["MessageTypeName"] = "Vx";
            //dt.Rows.Add(_ravi);
            MessageTypecomboBox.DataSource = dt.DefaultView;
            MessageTypecomboBox.DisplayMember = "MessageTypeName";
            MessageTypecomboBox.BindingContext = this.BindingContext;

            

        }

        public void GetMessageRequestType()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("MessageRequestType");
           
            DataRow _ravi = dt.NewRow();
            
            _ravi["MessageRequestType"] = "INBOUND";
            dt.Rows.Add(_ravi);

            _ravi = dt.NewRow();
            
            _ravi["MessageRequestType"] = "OUTBOUND";
            dt.Rows.Add(_ravi);


            MessageRequestTypecomboBox.DataSource = dt.DefaultView;
            MessageRequestTypecomboBox.DisplayMember = "MessageRequestType";
            MessageRequestTypecomboBox.BindingContext = this.BindingContext;


        }

        public int getOru()
        {
            int status, file;

            status = 0;
            file = 0;


            return status;

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            int MessageStatus = Convert.ToInt16(MessageStatuscomboBox.Text.ToString());
            string MessageRequestType = MessageRequestTypecomboBox.Text.ToString();
            string MessageType = MessageTypecomboBox.Text.ToString();
            
            BacklogWin.BusinessLogic.BAL bAL = new BacklogWin.BusinessLogic.BAL();
            DataTable dataTable = new DataTable();
            dataTable.Clear();
         
            dataTable = bAL.GetBcklog(MessageStatus, MessageRequestType, MessageType);

            BacklogdataGridView.DataSource = dataTable;
            BacklogdataGridView.Refresh();
            ///Notes Please assing this datatable to the grid
            ///


        }

        private void btnstatus_Click(object sender, EventArgs e)
        {
            logger.Info("search call started.");
            int MessageStatus = Convert.ToInt16(MessageStatuscomboBox.Text.ToString());
            string MessageRequestType = MessageRequestTypecomboBox.Text.ToString();
            logger.Info(MessageRequestType," type is ");
            string MessageType = MessageTypecomboBox.Text.ToString();
            logger.Info(MessageType);
            string column1Data = GetColumnData("MessageID",null);
            string column2Data = GetColumnData("MessageControlID",null);
            string column3Data = GetColumnData("ResponseMessageID", null);
            DataSet ds=new DataSet();
            logger.Info(ds);

            BacklogWin.BusinessLogic.BAL bAL = new BacklogWin.BusinessLogic.BAL();
            DataTable dataTable = new DataTable();
            logger.Info(dataTable);
            dataTable.Clear();
            //its will check the omal ,vx and mail message values  and update the finded message values status in messagelog
            if (MessageStatus == 1 && (MessageType == "OML" || MessageType == "mail"))
            {
                ds = bAL.CheckMessagValuesByMessageIds(MessageStatus, MessageRequestType, MessageType, column1Data, column2Data, "CheckMessageValueByIDs");
                logger.Info(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    string MessageValues = "";
                    string MessageControlIDs = "";
                    dataTable = ds.Tables[0];
                    foreach (DataRow row in dataTable.Rows)
                    {
                        MessageValues += row["MessageID"].ToString() + ",";
                        MessageControlIDs += row["MessageControlID"].ToString() + ",";

                    }
                    //its updation logicc
                    DataTable dataTable2 = new DataTable();
                    logger.Info(dataTable2);
                    dataTable2.Clear();
                    MessageValues = GetCommaString(MessageValues);
                    MessageControlIDs = GetCommaString(MessageControlIDs);
                  //its will be update those whoes messsage value exist
                    bAL.CheckMessagValuesByMessageIds(MessageStatus, MessageRequestType, MessageType,MessageValues, MessageControlIDs, "UpdateCheckMessageValuesAndUpdatemailvxOML");
                    MessageBox.Show("These Message Control IDs  Status updated: " + MessageControlIDs);
                    return;
                }
                //its for thoese whoese message value not exist
                if (ds.Tables[1].Rows.Count > 0)
                {
                   string MessageValues = "";
                    string MessageControlIDs = "";
                    dataTable = ds.Tables[1];
                    foreach (DataRow row in dataTable.Rows)
                    {
                        MessageValues += row["MessageID"].ToString() + ",";
                        MessageControlIDs += row["MessageControlID"].ToString() + ",";

                    }
                    DialogResult result = MessageBox.Show("These Message Ids not exist in Message Values"+ MessageValues+" Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Check the user's choice
                    if (result == DialogResult.Yes)
                    {
                        DataTable dataTable2 = new DataTable();
                        dataTable2.Clear();
                        MessageValues = GetCommaString(MessageValues);
                        MessageControlIDs = GetCommaString(MessageControlIDs);

                        //its will be update those whoes messsage value exist
                        bAL.CheckMessagValuesByMessageIds(MessageStatus, MessageRequestType, MessageType, MessageValues, MessageControlIDs, "UpdateCheckMessageValuesAndUpdatemailvxOML");
                        MessageBox.Show("These Message Control IDs  Status updated: " + MessageControlIDs);
                        // User clicked Yes, perform the desired action
                        // For example, navigate to another form or execute some code
                        // YourAction();
                        return;
                    }
                    else
                    {
                        // User clicked No, handle accordingly
                        // For example, do nothing or show another message
                        // HandleNoAction();
                    }
                   // MessageBox.Show("NO exist messageID in message values table");
                  
                }
            }

            if (MessageStatus == 1 && MessageType == "ORU")
            {
                ds = bAL.CheckMessagValuesByMessageIds(MessageStatus, MessageRequestType, MessageType,column1Data,column2Data, "CheckMessageValueByIDs");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string MessageValues = "";
                    string MessageControlIDs = "";
                    dataTable.Clear();
                    dataTable = ds.Tables[0];
                    foreach (DataRow row in dataTable.Rows)
                    {
                        MessageValues += row["MessageID"].ToString() + ",";
                        MessageControlIDs += row["MessageControlID"].ToString() + ",";

                    }
                    MessageValues = GetCommaString(MessageValues);
                    MessageControlIDs = GetCommaString(MessageControlIDs);
                    DataSet ds2 = new DataSet();
                    ds2 = bAL.CheckMessagValuesByMessageIds(MessageStatus, MessageRequestType, MessageType, MessageValues, MessageControlIDs, "CheckMessageResponseIDsForORU");
                    //its for which have message response ids
                    if (ds2.Tables[0].Rows.Count > 0)
                    {
                        string MessageValues1 = "";
                        string MessageControlIDs1 = "";
                        //its updation logicc
                        DataTable dataTable2 = new DataTable();
                        dataTable2.Clear();
                        dataTable2 = ds2.Tables[0];
                        foreach (DataRow row in dataTable2.Rows)
                        {
                            MessageValues1 += row["MessageID"].ToString() + ",";
                            MessageControlIDs1 += row["MessageControlID"].ToString() + ",";

                        }

                        MessageValues1 = GetCommaString(MessageValues1);
                        MessageControlIDs1 = GetCommaString(MessageControlIDs1);
                        bAL.CheckMessagValuesByMessageIds(MessageStatus, MessageRequestType, MessageType, MessageValues1, MessageControlIDs1, "UpdateCheckMessageValuesAndUpdatORU");
                        MessageBox.Show("These Message Control IDs  Status updated: " + MessageControlIDs1);
                        return;

                    }
                   
                   //its for which nave no response id 
                    if (ds2.Tables[1].Rows.Count > 0)
                    {
                        string MessageValues2 = "";
                        string MessageControlIDs2 = "";
                        dataTable.Clear();
                        dataTable = ds2.Tables[1];
                        foreach (DataRow row in dataTable.Rows)
                        {
                            MessageValues2 += row["MessageID"].ToString() + ",";
                            MessageControlIDs2 += row["MessageControlID"].ToString() + ",";

                        }
                        DialogResult result = MessageBox.Show("These Message Ids Have no Response Message IDs" + MessageValues2 + " Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Check the user's choice
                        if (result == DialogResult.Yes)
                        {
                            
                            MessageValues2 = GetCommaString(MessageValues2);
                            MessageControlIDs2 = GetCommaString(MessageControlIDs2);

                            //its will be update those whoes messsage value exist
                            bAL.CheckMessagValuesByMessageIds(MessageStatus, MessageRequestType, MessageType, MessageValues2, MessageControlIDs2, "UpdateCheckMessageValuesAndUpdatORU");
                            MessageBox.Show("These Message Control IDs  Status updated: " + MessageControlIDs);
                            // User clicked Yes, perform the desired action
                            // For example, navigate to another form or execute some code
                            // YourAction();
                            return;
                        }
                        else
                        {
                            // User clicked No, handle accordingly
                            // For example, do nothing or show another message
                            // HandleNoAction();
                        }
                    }
                }
                //its for thoese whoese message value not exist for oru
                if (ds.Tables[1].Rows.Count > 0)
                {
                    string MessageValues = "";
                    string MessageControlIDs = "";
                    dataTable = ds.Tables[1];
                    foreach (DataRow row in dataTable.Rows)
                    {
                        MessageValues += row["MessageID"].ToString() + ",";
                        MessageControlIDs += row["MessageControlID"].ToString() + ",";

                    }
                    DialogResult result = MessageBox.Show("These Message Ids not exist in Message Values" + MessageValues + " Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Check the user's choice
                    if (result == DialogResult.Yes)
                    {
                        DataTable dataTable2 = new DataTable();
                        dataTable2.Clear();
                        MessageValues = GetCommaString(MessageValues);
                        MessageControlIDs = GetCommaString(MessageControlIDs);
                        //its will be update those whoes messsage value exist
                        bAL.CheckMessagValuesByMessageIds(MessageStatus, MessageRequestType, MessageType, MessageValues, MessageControlIDs, "UpdateCheckMessageValuesAndUpdatORU");
                        MessageBox.Show("These Message Control IDs  Status updated: " + MessageControlIDs);
                        // User clicked Yes, perform the desired action
                        // For example, navigate to another form or execute some code
                        // YourAction();
                        return;
                    }
                    else
                    {
                        // User clicked No, handle accordingly
                        // For example, do nothing or show another message
                        // HandleNoAction();
                    }
                    // MessageBox.Show("NO exist messageID in message values table");
                 }
            }
            //  MessageBox.Show("Message values: " + MessageValues);
        }
        
        private string GetColumnData(string columnName,string column2)
        {
            if (BacklogdataGridView.Columns.Contains(columnName))
            {
                StringBuilder columnDataBuilder = new StringBuilder();

                foreach (DataGridViewRow row in BacklogdataGridView.Rows)
                {
                    if (row.Cells[columnName].Value != null)
                    {
                        columnDataBuilder.Append(row.Cells[columnName].Value.ToString());
                        columnDataBuilder.Append(",");
                    }
                }

                // Remove the last newline character if it exists
                if (columnDataBuilder.Length > 0)
                {
                    columnDataBuilder.Length--; // Removes the last character (newline)
                }

                return columnDataBuilder.ToString();
            }
            else
            {
                return "Column not found!";
            }
        }


        private string GetCommaString(string stringvalue)
        {
            
                StringBuilder columnDataBuilder = new StringBuilder();
            columnDataBuilder.Append(stringvalue);
            // Remove the last newline character if it exists
                if (columnDataBuilder.Length > 0)
                {
                    columnDataBuilder.Length--; // Removes the last character (newline)
                }

                return columnDataBuilder.ToString();
        }
    }
}
