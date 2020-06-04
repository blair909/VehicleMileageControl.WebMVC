using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VehicleMileageControl.Data;
using VehicleMileageControl.Model;
using VehicleMileageControl.Service;

namespace VehicleMileageControl.WebMVC.Controllers
{
    [Authorize]
    public class MaintenanceController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Maintenance
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new MaintenanceService(userId);
            var model = service.GetMaintenances();

            return View(model);
        }
        //The model item passed into the dictionary is of type 'VehicleMileageControl.Model.MaintenanceListItem[]', but this dictionary requires a model
        // item of type 'System.Collections.Generic.IEnumerable`1[VehicleMileageControl.Data.Maintenance]'.

        // GET: Maintenance
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Maintenance
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MaintenanceCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new MaintenanceService(userId);

            service.CreateMaintenance(model);

            return RedirectToAction("Index");
        }

        // GET: Delete
        // Maintenance/Delete/{id}
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maintenance maintenance = _db.Maintenances.Find(id);
            if (maintenance == null)
            {
                return HttpNotFound();
            }
            return View(maintenance);
        }

        // POST: Delete
        // Maintenance/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Maintenance maintenance = _db.Maintenances.Find(id);
            _db.Maintenances.Remove(maintenance);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Edit
        // Maintenance/Edit/{id}
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maintenance maintenance = _db.Maintenances.Find(id);
            if (maintenance == null)
            {
                return HttpNotFound();
            }
            return View(maintenance);
        }

        // POST: Edit
        // Maintenance/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Maintenance maintenance)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(maintenance).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(maintenance);
        }

        // GET: Details
        // Maintenance/Details/{id}
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maintenance maintenance = _db.Maintenances.Find(id);
            if (maintenance == null)
            {
                return HttpNotFound();
            }
            return View(maintenance);
        }
    }
}