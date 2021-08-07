using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskApplication.Models;
using TaskApplication.Models.Database;


namespace TaskApplication.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            Admin a = new Admin();
            return View(a);
        }

        [HttpPost]
        public ActionResult Index(Admin a)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();

               var data = db.Admins.Check(a);

               

                if (data!= null)
                {
                    return RedirectToAction("Dashboard");
                }
                else
                {
                    ViewBag.error = "Login failed";
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }


        public ActionResult List()
        {
            Database db = new Database();
            var students = db.Students.GetAll();
            return View(students);
        }
        public ActionResult Create()
        {
            Student s = new Student();
            return View(s);
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Students.Insert(s);
                return RedirectToAction("List");
     
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            Database db = new Database();
            var s = db.Students.Get(id);

            return View(s);
        }

        [HttpPost]
        public ActionResult Edit(Student s)
        {
            Database db = new Database();
            db.Students.Update(s);
            return RedirectToAction("List");

        }
        public ActionResult Delete(int id)
        {
            Database db = new Database();
            db.Students.delete(id);
            return RedirectToAction("List");
        }
    }
}