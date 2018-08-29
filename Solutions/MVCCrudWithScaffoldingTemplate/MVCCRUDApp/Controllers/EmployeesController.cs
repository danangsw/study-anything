using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCCRUDApp.Models;

namespace MVCCRUDApp.Controllers
{
    public class EmployeesController : Controller
    {
        private mvccrudEntities db = new mvccrudEntities();

        // GET: Employees
        public ActionResult Index()
        {
            List<EmployeeViewModel> list = new List<EmployeeViewModel>();

            foreach (var item in db.Employee.ToList())
            {
                list.Add(new EmployeeViewModel { NIP = item.NIP, Name = item.Name, Birthday = item.Birthday });
            }

            return View(list);
        }

        // GET: Employees/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(new EmployeeViewModel { NIP = employee.NIP, Name = employee.Name, Birthday = employee.Birthday });
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NIP,Name,Birthday")] EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                db.Employee.Add(new Employee { NIP = employee.NIP, Name = employee.Name, Birthday = employee.Birthday });
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(new EmployeeViewModel { NIP = employee.NIP, Name = employee.Name, Birthday = employee.Birthday });
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NIP,Name,Birthday")] EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(new Employee { NIP = employee.NIP, Name = employee.Name, Birthday = employee.Birthday }).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(new EmployeeViewModel { NIP = employee.NIP, Name = employee.Name, Birthday = employee.Birthday });
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(new EmployeeViewModel { NIP = employee.NIP, Name = employee.Name, Birthday = employee.Birthday });
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Employee employee = db.Employee.Find(id);
            db.Employee.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public JsonResult IsEmpNIPExist(string nip) {
            bool isExist = db.Employee.Find(nip) != null;
            return Json(!isExist, JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
