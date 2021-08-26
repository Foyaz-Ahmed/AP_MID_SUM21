using HRMApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRMApplication.Controllers
{
    public class HomeController : Controller
    {
        HRMSEntities context = new HRMSEntities();
        public ActionResult Index()
        {
            ViewBag.total_salary = context.Employees.Sum(e => e.Salary); 

           
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

            return View();
        }

    }
}