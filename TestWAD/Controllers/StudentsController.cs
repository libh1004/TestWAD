using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWAD.Data;
using TestWAD.Models;
using TestWAD.Models.ViewModel;
using static TestWAD.Models.Student;

namespace TestWAD.Controllers
{
    public class StudentsController : Controller
    {
        private MyDbContext db = new MyDbContext();
        // GET: Students
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Save(StudentViewModel studentViewModel)
        {
            var student = new Student()
            {
                Fines = (Models.FinesValue)studentViewModel.Fines,
                NumFines = studentViewModel.NumFines
            };
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult ListFines()
        {
            return View();
        }
    }
}