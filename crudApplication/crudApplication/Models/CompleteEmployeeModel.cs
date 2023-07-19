using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudApplication.Models
{
    public class CompleteEmployeeModel
    {
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public EmployeeModel employeeForm { get; set; } = new EmployeeModel();
        public List<EmployeeModel> employeeList { get; set; }
    }
}
