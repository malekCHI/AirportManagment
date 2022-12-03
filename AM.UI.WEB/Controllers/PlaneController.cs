using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Numerics;

namespace AM.UI.WEB.Controllers
{
    public class PlaneController : Controller


    {
        private readonly ServicePlane _planeService;
        public PlaneController(IServicePlan planeService)
        {
            _planeService = (ServicePlane?)planeService;
        }
        // GET: PlaneController
        public ActionResult Index()
        {
            return View(_planeService.GetAll().ToList());
        }

        // GET: PlaneController/Details/5
        public ActionResult Details(int id)
        {
            var plane = _planeService.GetById((int)id);
            if (plane == null)
            {
                return NotFound();
            }
            return View(plane);
        }

        // GET: PlaneController/Create
        public ActionResult Create()
        {

            ViewBag.PlaneType = new SelectList(Enum.GetNames(typeof(PlaneType)));
            return View();
        }

        // POST: PlaneController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                _planeService.Add((ApplicationCore.Domain.Plane)collection);
                _planeService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlaneController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plane = _planeService.GetById((int)id);
            if (plane == null)
            {
                return NotFound();
            }
            ViewBag.PlaneType = new SelectList(Enum.GetNames(typeof(PlaneType)));
            return View(plane);
        }

        // POST: PlaneController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                _planeService.Update((ApplicationCore.Domain.Plane)collection);
                _planeService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlaneController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var plane = _planeService.GetById((int)id);
            if (plane == null)
            {
                return NotFound();
            }

            return View(plane);
        }

        // POST: PlaneController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var plane = _planeService.GetById((int)id);
                _planeService.Delete(plane);
                _planeService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
