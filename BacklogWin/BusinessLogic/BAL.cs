using BacklogWin.db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacklogWin.BusinessLogic
{

    public class BAL
    {
        private readonly DBAccess _db;
        public BAL()
        {
            if (_db == null)
            {
                _db = new DBAccess();
            }

        }
        public DataTable GetBcklog(int MessageStatusID, string MessageRequestType, string MessageType)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parameters =
            {
           new SqlParameter("@MessageStatusID",SqlDbType.Int){Value=MessageStatusID},
           new SqlParameter("@MessageRequestType",SqlDbType.VarChar){Value=MessageRequestType},
           new SqlParameter("@MessageType",SqlDbType.VarChar){Value=MessageType},



     };


            DBHelpers dBHelpers = new DBHelpers();

            dBHelpers.SpName = "USP_Get_MessageLog";
            dBHelpers.SqlParameter = new SqlParameter[parameters.Count()];
            dBHelpers.SqlParameter = parameters;
            var ds = _db.DAL(dBHelpers);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;





        }





        public DataSet GetMessageStatus()
        {

            DataTable dt = new DataTable();
            //       SqlParameter[] parameters =
            //       {
            //      new SqlParameter("@Task",SqlDbType.VarChar){Value="GetBcklog"},
            //     new SqlParameter("@ID",SqlDbType.Int){Value=ID}


            //};


            DBHelpers dBHelpers = new DBHelpers();

            dBHelpers.SpName = "uspGetMessageStatus_Local";
            //dBHelpers.SqlParameter = new SqlParameter[parameters.Count()];
            dBHelpers.SqlParameter = null;
            var ds = _db.DAL(dBHelpers);
            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    dt = ds.Tables[0];

            //}
            //return dt;
            // uspGetMessageStatus_Local
            return ds;
        }


        public DataSet CheckMessagValuesByMessageIds(int MessageStatusID, string MessageRequestType, string MessageType,string MessageIds,string MessageControlIDs, string Task)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parameters =
            {
           new SqlParameter("@Task",SqlDbType.VarChar){Value=Task},
         new SqlParameter("@MessageStatusID",SqlDbType.Int){Value=MessageStatusID},
           new SqlParameter("@MessageRequestType",SqlDbType.VarChar){Value=MessageRequestType},
           new SqlParameter("@MessageType",SqlDbType.VarChar){Value=MessageType},
           new SqlParameter("@MessageIds",SqlDbType.VarChar){Value=MessageIds},
           new SqlParameter("@MessageControlIds",SqlDbType.VarChar){Value=MessageControlIDs}

    };


            DBHelpers dBHelpers = new DBHelpers();

            dBHelpers.SpName = "USP_CheckMessageValueByMessageIds";
            dBHelpers.SqlParameter = new SqlParameter[parameters.Count()];
            dBHelpers.SqlParameter = parameters;
            var ds = _db.DAL(dBHelpers);
            
            return ds;





        }


    }
}
