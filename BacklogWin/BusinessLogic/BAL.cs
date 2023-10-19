using BacklogWin.db;
using System;
using System.Collections.Generic;
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
    }
 
}
