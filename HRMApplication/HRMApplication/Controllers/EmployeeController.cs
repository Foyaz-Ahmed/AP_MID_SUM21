using HRMApplication.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRMApplication.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        // GET: Employee
        HRMSEntities context = new HRMSEntities();

        public ActionResult Index(string sortOrder, string sortBy)
        {
            ViewBag.sortOrder = sortOrder;
            var info = context.Employees.ToList();

            switch (sortBy)
            {
                case "Name":
                    {
                        switch (sortOrder)
                        {
                            case "Asc":
                                {
                                    info = info.OrderBy(e => e.Name).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    info = info.OrderByDescending(e => e.Name).ToList();
                                    break;
                                }
                            default:
                                {
                                    info = info.OrderBy(e => e.Name).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                case "Age":
                    {
                        switch (sortOrder)
                        {
                            case "Asc":
                                {
                                    info = info.OrderBy(e => e.Age).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    info = info.OrderByDescending(e => e.Age).ToList();
                                    break;
                                }
                            default:
                                {
                                    info = info.OrderBy(e => e.Age).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                case "JoiningDate":
                    {
                        switch (sortOrder)
                        {
                            case "Asc":
                                {
                                    info = info.OrderBy(e => e.JoiningDate).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    info = info.OrderByDescending(e => e.JoiningDate).ToList();
                                    break;
                                }
                            default:
                                {
                                    info = info.OrderBy(e => e.Age).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                case "Salary":
                    {
                        switch (sortOrder)
                        {
                            case "Asc":
                                {
                                    info = info.OrderBy(e => e.Salary).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    info = info.OrderByDescending(e => e.Salary).ToList();
                                    break;
                                }
                            default:
                                {
                                    info = info.OrderBy(e => e.Salary).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        info = info.OrderBy(e => e.Name).ToList();
                        break;
                    }
            }
            return View(info);
            //var employeesIfno = context.Employees.ToList();
            //return View(employeesIfno);
        }

        
        public ActionResult Create()
        {
            return View();

        }

        public JsonResult isCompanyEmailValidaiton(string Email)
        {
            return Json(data: !context.Employees.Any(x => x.Email == Email), JsonRequestBehavior.AllowGet);
        }
        
        [HttpPost]
        public ActionResult Create(Employee p)
        {
            if (ModelState.IsValid)
            {
                context.Employees.Add(p);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
            
        }


        public ActionResult Edit(int Id)
        {

            var p = context.Employees.FirstOrDefault(e => e.ID == Id);
            return View(p);
        }

        [HttpPost]
        public ActionResult Edit(Employee p)
        {
            if (ModelState.IsValid)
            {
                var old_value = context.Employees.FirstOrDefault(e => e.ID == p.ID);
                context.Entry(old_value).CurrentValues.SetValues(p);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Details(int Id)
        {
            var p = context.Employees.FirstOrDefault(e => e.ID == Id);
            return View(p);
        }
        public ActionResult Delete(int Id)
        {
            var p = context.Employees.FirstOrDefault(e => e.ID == Id);
            return View(p);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteP(int Id)
        {
            var employee_remove = context.Employees.FirstOrDefault(e => e.ID == Id);
            context.Employees.Remove(employee_remove);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult EmployeeInformations(string sortOrder, string sortBy)
        {

            

            ViewBag.sortOrder = sortOrder;
            EmployeeDetails empDepartment = new EmployeeDetails();
            empDepartment.details = (from employee in context.Employees
                                     join department in context.Departments
                                     on employee.Dept_ID equals department.ID
                                     join designation in context.Designations
                                     on employee.Desig_ID equals designation.desig_ID
                                     join company in context.Companies
                                     on employee.Comp_ID equals company.ID
                                     where(employee.Status == "Active")
                                     select new EmployeeDetails()
                                     {
                                         Id = employee.ID,
                                         Name = employee.Name,
                                         CompanyName = company.C_Name,
                                         DepartmentName = department.D_Name,
                                         DesignationName = designation.Ds_Name,
                                         Age = employee.Age,
                                         Salary = employee.Salary,
                                         JoiningDate = employee.JoiningDate
                                     }).ToList();

            switch (sortBy)
            {
                case "Name":
                    {
                        switch (sortOrder)
                        {
                            case "Asc":
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.Name).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    empDepartment.details = empDepartment.details.OrderByDescending(e => e.Name).ToList();
                                    break;
                                }
                            default:
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.Name).ToList();
                                    break;
                                }
                        }
                        break;
                    }

                case "Age":
                    {
                        switch (sortOrder)
                        {
                            case "Asc":
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.Age).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    empDepartment.details = empDepartment.details.OrderByDescending(e => e.Age).ToList();
                                    break;
                                }
                            default:
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.Age).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                case "JoiningDate":
                    {
                        switch (sortOrder)
                        {
                            case "Asc":
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.JoiningDate).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    empDepartment.details = empDepartment.details.OrderByDescending(e => e.JoiningDate).ToList();
                                    break;
                                }
                            default:
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.Age).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                case "Salary":
                    {
                        switch (sortOrder)
                        {
                            case "Asc":
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.Salary).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    empDepartment.details = empDepartment.details.OrderByDescending(e => e.Salary).ToList();
                                    break;
                                }
                            default:
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.Salary).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                case "DesignationName":
                    {
                        switch (sortOrder)
                        {
                            case "Asc":
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.DesignationName).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    empDepartment.details = empDepartment.details.OrderByDescending(e => e.DesignationName).ToList();
                                    break;
                                }
                            default:
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.DesignationName).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                case "DepartmentName":
                    {
                        switch (sortOrder)
                        {
                            case "Asc":
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.DepartmentName).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    empDepartment.details = empDepartment.details.OrderByDescending(e => e.DepartmentName).ToList();
                                    break;
                                }
                            default:
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.DepartmentName).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                case "CompanyName":
                    {
                        switch (sortOrder)
                        {
                            case "Asc":
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.CompanyName).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    empDepartment.details = empDepartment.details.OrderByDescending(e => e.CompanyName).ToList();
                                    break;
                                }
                            default:
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.CompanyName).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        empDepartment.details = empDepartment.details.OrderBy(e => e.Name).ToList();
                        break;
                    }
            }

            var cmp = context.Companies.ToList();

            dynamic mymodel = new ExpandoObject();
            mymodel.details_emp = empDepartment.details;
            mymodel.company_name = cmp;
            return View(mymodel);

        }

        public ActionResult ITDepartment()
        {

            EmployeeDetails empDepartment = new EmployeeDetails();
            empDepartment.details = (from employee in context.Employees
                                     join department in context.Departments
                                     on employee.Dept_ID equals department.ID
                                     join designation in context.Designations
                                     on employee.Dept_ID equals designation.desig_ID
                                     join company in context.Companies
                                     on employee.Comp_ID equals company.ID
                                     where (department.D_Name == "IT" && employee.Status == "Active")
                                     select new EmployeeDetails()
                                     {
                                         Id = employee.ID,
                                         Name = employee.Name,
                                         CompanyName = company.C_Name,
                                         DepartmentName = department.D_Name,
                                         DesignationName = designation.Ds_Name,
                                         Age = employee.Age,
                                         Salary = employee.Salary,
                                         JoiningDate = employee.JoiningDate
                                     }).ToList();
            return View(empDepartment);

        }

        public ActionResult MarketingDepartment()
        {

            EmployeeDetails empDepartment = new EmployeeDetails();
            empDepartment.details = (from employee in context.Employees
                                     join department in context.Departments
                                     on employee.Dept_ID equals department.ID
                                     join designation in context.Designations
                                     on employee.Dept_ID equals designation.desig_ID
                                     join company in context.Companies
                                     on employee.Comp_ID equals company.ID
                                     where (department.D_Name == "Marketing" && employee.Status == "Active")
                                     select new EmployeeDetails()
                                     {
                                         Id = employee.ID,
                                         Name = employee.Name,
                                         CompanyName = company.C_Name,
                                         DepartmentName = department.D_Name,
                                         DesignationName = designation.Ds_Name,
                                         Age = employee.Age,
                                         Salary = employee.Salary,
                                         JoiningDate = employee.JoiningDate
                                     }).ToList();
            return View(empDepartment);

        }

        public ActionResult SellsDepartment()
        {

            EmployeeDetails empDepartment = new EmployeeDetails();
            empDepartment.details = (from employee in context.Employees
                                     join department in context.Departments
                                     on employee.Dept_ID equals department.ID
                                     join designation in context.Designations
                                     on employee.Desig_ID equals designation.desig_ID
                                     join company in context.Companies
                                     on employee.Comp_ID equals company.ID
                                     where (department.D_Name == "Sells" && employee.Status == "Active")
                                     select new EmployeeDetails()
                                     {
                                         Id = employee.ID,
                                         Name = employee.Name,
                                         CompanyName = company.C_Name,
                                         DepartmentName = department.D_Name,
                                         DesignationName = designation.Ds_Name,
                                         Age = employee.Age,
                                         Salary = employee.Salary,
                                         JoiningDate = employee.JoiningDate
                                     }).ToList();
            return View(empDepartment);

        }

        [HttpPost]
        public ActionResult EmployeeInformations(string Name)
        {
            EmployeeDetails empDepartment = new EmployeeDetails();
            empDepartment.details = (from employee in context.Employees
                                     join department in context.Departments
                                     on employee.Dept_ID equals department.ID
                                     join designation in context.Designations
                                     on employee.Desig_ID equals designation.desig_ID
                                     join company in context.Companies
                                     on employee.Comp_ID equals company.ID
                                     where (employee.Status == "Active")
                                     select new EmployeeDetails()
                                     {
                                         Id = employee.ID,
                                         Name = employee.Name,
                                         CompanyName = company.C_Name,
                                         DepartmentName = department.D_Name,
                                         DesignationName = designation.Ds_Name,
                                         Age = employee.Age,
                                         Salary = employee.Salary,
                                         JoiningDate = employee.JoiningDate
                                     }).ToList();
            if (Name != null)
            {

            
                empDepartment.details = (from employee in context.Employees
                                         join department in context.Departments
                                         on employee.Dept_ID equals department.ID
                                         join designation in context.Designations
                                         on employee.Desig_ID equals designation.desig_ID
                                         join company in context.Companies
                                         on employee.Comp_ID equals company.ID
                                         where (employee.Status == "Active")
                                         where (employee.Name.Contains(Name) || department.D_Name.Contains(Name) ||
                                         designation.Ds_Name.Contains(Name) || company.C_Name.Contains(Name) || employee.Age.ToString().Contains(Name))
                                         select new EmployeeDetails()
                                         {
                                             Id = employee.ID,
                                             Name = employee.Name,
                                             CompanyName = company.C_Name,
                                             DepartmentName = department.D_Name,
                                             DesignationName = designation.Ds_Name,
                                             Age = employee.Age,
                                             Salary = employee.Salary,
                                             JoiningDate = employee.JoiningDate
                                         }).ToList();


            }

            var cmp = context.Companies.ToList();

            dynamic mymodel = new ExpandoObject();
            mymodel.details_emp = empDepartment.details;
            mymodel.company_name = cmp;
            return View(mymodel);

        }

        public ActionResult CompanyInfo(int id, string sortOrder, string sortBy)
        {
            ViewBag.sortOrder = sortOrder;
            EmployeeDetails empDepartment = new EmployeeDetails();
            empDepartment.details = (from employee in context.Employees
                                     join department in context.Departments
                                     on employee.Dept_ID equals department.ID
                                     join designation in context.Designations
                                     on employee.Desig_ID equals designation.desig_ID
                                     join company in context.Companies
                                     on employee.Comp_ID equals company.ID
                                     where (employee.Status == "Active" && company.ID == id)
                                     select new EmployeeDetails()
                                     {
                                         Id = employee.ID,
                                         Name = employee.Name,
                                         CompanyName = company.C_Name,
                                         DepartmentName = department.D_Name,
                                         DesignationName = designation.Ds_Name,
                                         Age = employee.Age,
                                         Salary = employee.Salary,
                                         JoiningDate = employee.JoiningDate
                                     }).ToList();

            switch (sortBy)
            {
                case "Name":
                    {
                        switch (sortOrder)
                        {

                            case "Asc":
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.Name).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    empDepartment.details = empDepartment.details.OrderByDescending(e => e.Name).ToList();
                                    break;
                                }
                            default:
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.Name).ToList();
                                    break;
                                }
                        }
                        break;
                    }

                case "Age":
                    {
                        switch (sortOrder)
                        {
                            case "Asc":
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.Age).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    empDepartment.details = empDepartment.details.OrderByDescending(e => e.Age).ToList();
                                    break;
                                }
                            default:
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.Age).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                case "JoiningDate":
                    {
                        switch (sortOrder)
                        {
                            case "Asc":
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.JoiningDate).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    empDepartment.details = empDepartment.details.OrderByDescending(e => e.JoiningDate).ToList();
                                    break;
                                }
                            default:
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.Age).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                case "Salary":
                    {
                        switch (sortOrder)
                        {
                            case "Asc":
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.Salary).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    empDepartment.details = empDepartment.details.OrderByDescending(e => e.Salary).ToList();
                                    break;
                                }
                            default:
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.Salary).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                case "DesignationName":
                    {
                        switch (sortOrder)
                        {
                            case "Asc":
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.DesignationName).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    empDepartment.details = empDepartment.details.OrderByDescending(e => e.DesignationName).ToList();
                                    break;
                                }
                            default:
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.DesignationName).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                case "DepartmentName":
                    {
                        switch (sortOrder)
                        {
                            case "Asc":
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.DepartmentName).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    empDepartment.details = empDepartment.details.OrderByDescending(e => e.DepartmentName).ToList();
                                    break;
                                }
                            default:
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.DepartmentName).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                case "CompanyName":
                    {
                        switch (sortOrder)
                        {
                            case "Asc":
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.CompanyName).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    empDepartment.details = empDepartment.details.OrderByDescending(e => e.CompanyName).ToList();
                                    break;
                                }
                            default:
                                {
                                    empDepartment.details = empDepartment.details.OrderBy(e => e.CompanyName).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        empDepartment.details = empDepartment.details.OrderBy(e => e.Name).ToList();
                        break;
                    }
            }

            var cmp = context.Companies.ToList();

            dynamic mymodel = new ExpandoObject();
            mymodel.details_emp = empDepartment.details;
            mymodel.company_name = cmp;
            return View(mymodel);

        }

    }

}