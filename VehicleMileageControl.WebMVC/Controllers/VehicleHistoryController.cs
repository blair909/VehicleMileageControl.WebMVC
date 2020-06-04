using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VehicleMileageControl.Data;
using VehicleMileageControl.Model.VehicleHistoryModel;

namespace VehicleMileageControl.WebMVC.Controllers
{
    [Authorize]
    public class VehicleHistoryController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: VehicleHistory
        public ActionResult Index()
        {
            var model = new VehicleHistoryListItem[0];
            return View(model);
        }

        // GET: VehicleHistory
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleHistory
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VehicleHistory vehicleHistory)
        {
            if (ModelState.IsValid)
            {
                _db.VehicleHistorys.Add(vehicleHistory);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehicleHistory);
        }

        // GET: Delete
        // VehicleHistory/Delete/{id}
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleHistory vehicleHistory = _db.VehicleHistorys.Find(id);
            if (vehicleHistory == null)
            {
                return HttpNotFound();
            }
            return View(vehicleHistory);
        }

        // POST: Delete
        // VehicleHistory/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            VehicleHistory vehicleHistory = _db.VehicleHistorys.Find(id);
            _db.VehicleHistorys.Remove(vehicleHistory);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Edit
        // VehicleHistory/Edit/{id}
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleHistory vehicleHistory = _db.VehicleHistorys.Find(id);
            if (vehicleHistory == null)
            {
                return HttpNotFound();
            }
            return View(vehicleHistory);
        }

        // POST: Edit
        // VehicleHistory/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VehicleHistory vehicleHistory)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(vehicleHistory).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehicleHistory);
        }

        // GET: Details
        // VehicleHistory/Details/{id}
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleHistory vehicleHistory = _db.VehicleHistorys.Find(id);
            if (vehicleHistory == null)
            {
                return HttpNotFound();
            }
            return View(vehicleHistory);
        }
    }
}