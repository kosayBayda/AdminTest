using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace AdminTestWebApp.Controllers
{
    public class DepartmentController : Controller
    {
        DBLayer.Classes.Department departmentTable = new DBLayer.Classes.Department();
        // GET: DepartmentController
        public ActionResult Index()
        {
            return View(departmentTable.GetDepartments());
        }

        // GET: DepartmentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                StringValues title;
                collection.TryGetValue("title", out title);
                departmentTable.insertDepartment(title);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(departmentTable.getDepartmentById(id));
        }

        // POST: DepartmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                StringValues title;
                collection.TryGetValue("title", out title);
                departmentTable.updateDepartment(id, title.ToString());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(departmentTable.getDepartmentById(id));
        }

        // POST: DepartmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            //try
            //{
                departmentTable.deleteDepartmentById(id);
                return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
        }
    }
}
