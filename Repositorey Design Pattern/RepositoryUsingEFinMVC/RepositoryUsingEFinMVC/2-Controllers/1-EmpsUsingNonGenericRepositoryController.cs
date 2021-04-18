using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RepositoryUsingEFinMVC.Models;
using RepositoryUsingEFinMVC.RepositoryDP.NonGenericRepositoryDP;

namespace RepositoryUsingEFinMVC.Controllers
{
    public class EmpsUsingNonGenericRepositoryController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public EmpsUsingNonGenericRepositoryController()
        {
            _employeeRepository = new EmployeeRepository(new EmployeeDBContext());
        }
        public ActionResult Index()
        {
            var x = _employeeRepository.GetAll();

            return View(x);

        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = _employeeRepository.GetById(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.Insert(employee);
                _employeeRepository.Save();
                return RedirectToAction("Index");
            }

            return View(employee);
        }


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = _employeeRepository.GetById(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.Update(employee);
                _employeeRepository.Save();
                return RedirectToAction("Index");
            }
            return View(employee);
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = _employeeRepository.GetById(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }



        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _employeeRepository.Delete(id);
            _employeeRepository.Save();
            return RedirectToAction("Index");
        }


        protected override void Dispose(bool disposing)
        {
            _employeeRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
