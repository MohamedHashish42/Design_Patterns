using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RepositoryUsingEFinMVC.Models;
using RepositoryUsingEFinMVC.UnitofWork;

namespace RepositoryUsingEFinMVC.Controllers
{
    public class EmpsUsingUnitOfWorkController : Controller
    {
        private UnitOfWork unitOfWork;
        private IEmployeeRepository _employeeRepository;

        public EmpsUsingUnitOfWorkController()
        {
            unitOfWork = new UnitOfWork(new EmployeeDBContext());
            _employeeRepository = unitOfWork.Employees;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = _employeeRepository.GetAll();
            return View(model);
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee model)
        {
            try
            {
                unitOfWork.CreateTransaction();
                if (ModelState.IsValid)
                {
                    _employeeRepository.Insert(model);
                    unitOfWork.Save();
                    //Do Some Other Task with the Database
                    //If everything is working then commit the transaction else rollback the transaction
                    unitOfWork.Commit();
                    return RedirectToAction("Index", "Employee");
                }
            }
            catch
            {
                unitOfWork.Rollback();
            }
            return View();
        }


        [HttpGet]
        public ActionResult EditEmployee(int EmployeeId)
        {
            Employee model = _employeeRepository.GetById(EmployeeId);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditEmployee(Employee model)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.Update(model);
                unitOfWork.Save();
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                return View(model);
            }
        }


        [HttpGet]
        public ActionResult DeleteEmployee(int EmployeeId)
        {
            Employee model = _employeeRepository.GetById(EmployeeId);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int EmployeeID)
        {
            _employeeRepository.Delete(EmployeeID);
            unitOfWork.Save();
            return RedirectToAction("Index", "Employee");
        }
    }
}
