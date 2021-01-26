    using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTestWebApp.Controllers
{

    public class AssetController : Controller
    {
        DBLayer.Classes.Asset assetTable = new DBLayer.Classes.Asset();

        // GET: AssetController
        public ActionResult Index()
        {
            return View(assetTable.GetAssets());
        }

        // GET: AssetController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AssetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AssetController/Create
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

        // GET: AssetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AssetController/Edit/5
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

        // GET: AssetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AssetController/Delete/5
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
