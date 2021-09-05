using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HRMApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login\
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Id, string Password, string returnUrl)
        {
            if(Id ==  "12345" && Password== "12345")
            {
                FormsAuthentication.SetAuthCookie("foyaz", false);
                //return RedirectToAction("Index", "Home");
                return Redirect("/Home");
            }

            else
            {
                ViewBag.message = "Empty Field or Your are given wrong info";

            }

            return View();

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return Redirect("/Login");

        }
    }
}