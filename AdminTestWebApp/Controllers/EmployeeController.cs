using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTestWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        DBLayer.Classes.Employee employeeTable = new DBLayer.Classes.Employee();
        DBLayer.Classes.Department departmentTable = new DBLayer.Classes.Department();
        // GET: EmployeeController
        public ActionResult Index()
        {
            return View(employeeTable.GetEmployees());
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            ViewData["departments"] = departmentTable.GetDepartments();
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                StringValues firstName;
                collection.TryGetValue("firstName", out firstName);
                StringValues lastName;
                collection.TryGetValue("lastName", out lastName);
                StringValues departmentId;
                collection.TryGetValue("departmentId", out departmentId);
                employeeTable.insertEmployee(firstName.ToString(), lastName.ToString(),int.Parse(departmentId.ToString()));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
