using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BacklogWin.db
{
    public class DBAccess
    {
   
        readonly string _FirstConnection = ConfigurationManager.ConnectionStrings["ConectionStringHealthLinkSeven"].ConnectionString.ToString();
     


        //readonly string _FirstConnection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString().Replace("#@!", "dbo#");
        //readonly string _SecondConnection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString().Replace("#@!", "dbo#");

        public void DML(DBHelpers obj)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_FirstConnection))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(obj.SpName.ToString(), conn);
                    cmd.CommandTimeout = 99999;
                    cmd.CommandType = CommandType.StoredProcedure;
                    for (int i = 0; i <= obj.SqlParameter.Length - 1; i++)
                    {

                        cmd.Parameters.Insert(i, obj.SqlParameter[i]);

                    }
                    cmd.ExecuteNonQuery();
                    //conn.Close();
                    cmd.Dispose();

                }
            }
            catch (DataException)
            { 
            
            }
            catch(Exception ex) {
                
            
            }
        }
        /// <summary>
        /// This is use to select
        /// </summary>
        /// <param name="obj"></param>

        public DataSet DAL(DBHelpers obj)
        {

            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection conn = new SqlConnection(_FirstConnection))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(obj.SpName.ToString(), conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 99999;
                    if (obj.SqlParameter != null)
                    {
                        for (int i = 0; i <= obj.SqlParameter.Length - 1; i++)
                        {
                            cmd.Parameters.Insert(i, obj.SqlParameter[i]);
                        }
                    }
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    conn.Close();
                    cmd.Dispose();
                }
            }
            catch (DataException)
            {
                return ds;
            }
            return ds;
        }
        public int InsertOutPut(DBHelpers obj)
        {
            // DataSet ds = new DataSet();
            int res = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(_FirstConnection))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(obj.SpName.ToString(), conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (obj.SqlParameter != null)
                    {
                        for (int i = 0; i <= obj.SqlParameter.Length - 1; i++)
                        {
                            cmd.Parameters.Insert(i, obj.SqlParameter[i]);

                        }
                    }
                    cmd.ExecuteNonQuery();

                    int Checkrecord = int.Parse(cmd.Parameters["@checkRecord"].Value.ToString());
                    res = Convert.ToInt32(Checkrecord);
                    //SqlDataAdapter adp = new SqlDataAdapter(cmd.ExecuteScalar());
                    // adp.Fill(ds);
                    conn.Close();
                    cmd.Dispose();
                }

            }
            catch (DataException)
            {
                ///return ds;
            }
            // return ds;
            return res;
        }

      
    }
}

