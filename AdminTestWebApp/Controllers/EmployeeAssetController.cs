using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTestWebApp.Controllers
{
    public class EmployeeAssetController : Controller
    {
        DBLayer.Classes.EmployeeAsset employeesAssets = new DBLayer.Classes.EmployeeAsset();
        // GET: EmployeeAssetController
        public ActionResult Index()
        {

            return View(employeesAssets.GetEmployeesAssets());
        }

        // GET: EmployeeAssetController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeAssetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeAssetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: EmployeeAssetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeAssetController/Edit/5
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

        // GET: EmployeeAssetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeAssetController/Delete/5
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
