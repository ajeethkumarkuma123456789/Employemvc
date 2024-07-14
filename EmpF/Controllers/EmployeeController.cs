using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpF.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            using (SchoolDBEntities dbmodel = new SchoolDBEntities())
            {
                return View(dbmodel.Task3.ToList());
            }
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            using (SchoolDBEntities dbmodel = new SchoolDBEntities())
            {
                return View(dbmodel.Task3.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Task3 task3)
        {
            try
            {
                using (SchoolDBEntities dbmodel = new SchoolDBEntities())
                {
                    dbmodel.Task3.Add(task3);
                    dbmodel.SaveChanges();

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            using (SchoolDBEntities dbmodel = new SchoolDBEntities())
            {
                return View(dbmodel.Task3.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Task3 task3)
        {
            try
            {
                using (SchoolDBEntities dbmodel = new SchoolDBEntities())
                {
                    dbmodel.Entry(task3).State = EntityState.Modified;
                    dbmodel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            using (SchoolDBEntities dbmodel = new SchoolDBEntities())
            {
                return View(dbmodel.Task3.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (SchoolDBEntities dbmodel = new SchoolDBEntities())
                {
                    Task3 student = dbmodel.Task3.Where(x => x.Id == id).FirstOrDefault();
                    dbmodel.Task3.Remove(student);
                    dbmodel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
