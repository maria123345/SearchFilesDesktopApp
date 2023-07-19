using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using crudApplication.Models;
using System.Web.Http;

namespace crudApplication.Controllers
{
  
    public class employeeController : Controller
    {


        private readonly ILogger<employeeController> _logger;
        private readonly EMployeeContext dbcontext;

        
       public employeeController(ILogger<employeeController> logger,EMployeeContext context)
        {
            _logger = logger;
            this.dbcontext = context;
           
        }
  
        public IActionResult Index()
        {
            try
            {
                loadDDL();

                //TempData[]
                //if (TempData["Message"] != null)
                //{
                //    TempData.Keep("Message");
                //}
                   
                //var resultemployee = dbcontext.tbl_employee.ToList();
                //var resultDepartment = context.Department.ToList();
                var resultemployee = from a in dbcontext.tbl_employee
                                     join b in dbcontext.tbl_department
                                     on a.DepID equals b.ID into Dep
                                     from b in Dep.DefaultIfEmpty()
                                     select new EmployeeModel
                                     {
                                         Id = a.Id,
                                         Name = a.Name,
                                         LastName = a.LastName,
                                         Email = a.Email,
                                         Brithdate = a.Brithdate,
                                         Gender = a.Gender,
                                         Phone = a.Phone,
                                         Joindate = a.Joindate,
                                         DepID=a.DepID,
                                         Department=b==null?"":b.Department


                                     };
                var model = new CompleteEmployeeModel();

                model.employeeList = resultemployee.ToList();
                model.employeeForm = new EmployeeModel();
                return View(model);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> EditEmployee(CompleteEmployeeModel obj)
        {
            try {
                ///if (obj.Id!=)
                if (ModelState.IsValid)
                {
                    loadDDL();
                    dbcontext.Entry(obj.employeeForm).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                else
                {
                    ViewBag.ErrorMessage = "dfg";
                    return View("CreateEmployee");
                }
            } catch(Exception ex) {
                throw ex;
            }
            return RedirectToAction("Index");
        }
            [HttpGet]
        public IActionResult CreateEmployee(int Id)
        {
            CompleteEmployeeModel obj = new CompleteEmployeeModel();

            if (Id == 0)
            {
                loadDDL();
              

                ModelState.Clear();
                return PartialView(obj);
            }
            else
            {
             
                obj.employeeForm = dbcontext.tbl_employee.Where(x => x.Id == Id).FirstOrDefault();
                loadDDL();


                return View(obj);
            }
               
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
       
                                                                                                                                                                      
        public async Task<IActionResult> AddEmployee(CompleteEmployeeModel obj)
        {
            try
            {
            
                if (ModelState.IsValid)
                {
                    if (obj.employeeForm.Id == 0)
                    {
                        dbcontext.tbl_employee.Add(obj.employeeForm);

                        await dbcontext.SaveChangesAsync();
                        TempData["Message"] = "Record Inserted successfully";
                    }
                    else
                    {
                        //dbcontext.tbl_employee.Find().;
                        //await dbcontext.SaveChangesAsync();
                        ///obj.Id = 0;
                        dbcontext.Entry(obj.employeeForm).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        await dbcontext.SaveChangesAsync();
                        TempData["Message"] = "Update Record successfully";
                    }

                }
                else {
                    loadDDL();
                    //if error ata ha to pir yeah view aya warna wo listview pa ja
                    return View("CreateEmployee", obj);
                }
                return RedirectToAction("Index",obj.employeeList);
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index");

            }
        }
     [HttpDelete]
        
        public async Task<IActionResult> Del(int id){
            try
            {
                var del = await dbcontext.tbl_employee.FindAsync(id);
                if(del!=null)
                {
                    dbcontext.tbl_employee.Remove(del);
                    await dbcontext.SaveChangesAsync();
                    TempData["Message"] = "Delete Record successfully";
                }
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {

                return RedirectToAction("Index");
            }
            {

            }
        }

        private void loadDDL()
        {
            try
            {
                List<DepartmentModel> deplist = new List<DepartmentModel>();
                deplist = dbcontext.tbl_department.ToList();
                deplist.Insert(0, new DepartmentModel { ID = 0, Department = "Please Select" });
                ViewBag.Deplist = deplist;
            }
            catch(Exception ex)
            {

            }
        }
    }
   




}