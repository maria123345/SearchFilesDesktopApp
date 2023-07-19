using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using crudApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crudApplication.Controllers
{
    [Route("api/EmpAPI")]
    public class EmpAPIController : Controller
    {
        // GET: api/EmpAPI
        public static EMployeeContext _dbcontextt;
        public EmpAPIController(EMployeeContext dbcontext)
        {
            _dbcontextt = dbcontext;
        }



        [HttpGet]
        [Route("ALLEmployee")]
        public Task<CompleteEmployeeModel> GetAllEmployee()
       
        {
            CompleteEmployeeModel obj1 = new CompleteEmployeeModel();
            obj1.employeeList = new List<EmployeeModel>();
            try
            {
                var resultemployee = from a in _dbcontextt.tbl_employee
                                     join b in _dbcontextt.tbl_department
                                     on a.DepID equals b.ID into Dep
                                     from b in Dep.DefaultIfEmpty()
                                     select new EmployeeModel
                                     {
                                         Id = a.Id,
                                         Name = a.Name ,
                                         LastName = a.LastName,
                                         Email = a.Email,
                                         Brithdate = a.Brithdate,
                                         Gender = a.Gender,
                                         Phone = a.Phone,
                                         Joindate = a.Joindate,
                                         DepID = a.DepID,
                                         Department = b == null ? "" : b.Department


                                     };

                obj1.employeeList = resultemployee.ToList();
                obj1.employeeForm = new EmployeeModel();
                
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                throw;
            }
            return Task.FromResult(obj1);
        }

        [HttpPost]
        [Route("ADDEmployee")]

        public Task<string> AddEmployee([FromForm] EmployeeModel obj)
        {

            //CompleteEmployeeModel obj1 = new CompleteEmployeeModel()
            var result = "";

            try
            {
               if(!string.IsNullOrEmpty(obj.Name) && !string.IsNullOrEmpty(obj.LastName) && !string.IsNullOrEmpty(obj.Email)) {

                    if (obj.Id == 0)
                    {
                        _dbcontextt.tbl_employee.Add(obj);

                        _dbcontextt.SaveChangesAsync();
                        result = "Record Inserted successfully";
                    }

                }
                    
              
                

            }

            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                throw;
            }
            return Task.FromResult(result);
        }
        [HttpPut]
        [Route("UpdateEmployee")]

        public Task<string> UpdateEmployee([FromForm] CompleteEmployeeModel obj)
        {
            var result = "";

            try
            {
                if (obj.employeeForm.Id != 0)
                {

                    _dbcontextt.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    _dbcontextt.SaveChangesAsync();

                    result = "Update Inserted successfully";
                }

            }

            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                throw;
            }
            return Task.FromResult(result);
        }





        [HttpDelete]
        [Route("DeleteEmployee")]
        public Task<string> RemoveEmployee(int id)
        {
            CompleteEmployeeModel obj = new CompleteEmployeeModel();
            //  obj. = new List<EmployeeModel>();
            var result = "";
            try
            {
                dynamic del =  _dbcontextt.tbl_employee.Find(id);
                if (del != null)
                {
                    _dbcontextt.tbl_employee.Remove(del);
                     _dbcontextt.SaveChangesAsync();
                     result = "Delete Record successfully";
                }
                return Task.FromResult(result);
            }
            catch (Exception ext)
            {
                Debug.Write(ext.Message);
                throw ext;
            }
        }
    }
}
