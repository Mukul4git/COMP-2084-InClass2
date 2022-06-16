using COMP_2084_InClass1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace COMP_2084_InClass1.Controllers
{
    public class CarsController : Controller
    {

        static List<CarsModel> carList = new List<CarsModel> { 
        
            new CarsModel { Id = 1, Name = "Toyota"},
            new CarsModel { Id = 2, Name = "Nissan"},
            new CarsModel { Id = 3, Name = "Honda"}

        }; 

        // GET: CarsController
        public ActionResult Index()
        {
            return View(carList);
        }

        // GET: CarsController/Details/5
        public ActionResult Details(int id)
        {
            var selected = carList.First<CarsModel>(x => x.Id == id);
            return View(selected);
        }

        // GET: CarsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarsController/Create
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

        // GET: CarsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarsController/Edit/5
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

        // GET: CarsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarsController/Delete/5
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
