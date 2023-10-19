using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacklogWin.db
{
    public class DBHelpers
    {
        public SqlParameter[] SqlParameter;
        public string SpName { get; set; }
    }
}
