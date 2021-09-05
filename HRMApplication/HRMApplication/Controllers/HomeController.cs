using HRMApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRMApplication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        HRMSEntities context = new HRMSEntities();
        public ActionResult Index()
        {
            ViewBag.total_salary = context.Employees.Sum(e => e.Salary)
                                    ;
            ViewBag.total_1 = context.Employees.Where(f => f.Comp_ID == 1).Sum( s => s.Salary);
            ViewBag.total_2 = context.Employees.Where(g => g.Comp_ID == 1002).Sum( v => v.Salary);
            ViewBag.total_3 = context.Employees.Where(f => f.Comp_ID == 2003).Sum( s => s.Salary);

           
            var countfr = context.Designations.Count(t => t.Ds_Name == "Manager");
            ViewBag.count_forward = countfr;

            var countcdm = context.Designations.Count(t => t.Ds_Name == "Sr Software Eng");
            ViewBag.count_cdm = countcdm;

            var countcdm1 = context.Designations.Count(t => t.Ds_Name == "Jr Software Eng");
            ViewBag.count_cdm1 = countcdm;

            var countgk = context.Designations.Count(t => t.Ds_Name == "Seller");
            ViewBag.count_gk = countgk;

            var countdf = context.Designations.Count(t => t.Ds_Name == "Jr Exicutive");
            ViewBag.count_df = countdf;

            ViewBag.total = countfr + countcdm + countcdm1 + countgk + countdf;

            /////////////////company Employees individual///////////////////////////

            var countorganic = context.Employees.Where(x => x.Status== "Active").Count( t => t.Comp_ID == 1);
            ViewBag.count_company1 = countorganic;

            var count_foodpanda = context.Employees.Where(x => x.Status == "Active").Count(t => t.Comp_ID == 1002);
            ViewBag.count_company2 = count_foodpanda;

            var count_bdorganic = context.Employees.Where(x => x.Status == "Active").Count(t => t.Comp_ID == 2003);
            ViewBag.count_company3 = count_bdorganic;

            return View();
        }

    }
}