using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudApplication.Models
{
    public class EMployeeContext : DbContext
    {
        public EMployeeContext(DbContextOptions<EMployeeContext> options) : base(options)
        { }
        public DbSet<EmployeeModel> tbl_employee { get; set; }
        public DbSet<DepartmentModel> tbl_department { get; set; }
    }
}
