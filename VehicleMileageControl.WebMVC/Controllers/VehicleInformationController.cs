using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VehicleMileageControl.Data;
using VehicleMileageControl.Model.VehicleInformation;
using VehicleMileageControl.Model.VehicleInformationModel;
using VehicleMileageControl.Service;

namespace VehicleMileageControl.WebMVC.Controllers
{
    [Authorize]
    public class VehicleInformationController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: VehicleInformation
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new VehicleInformationService(userId);
            var model = service.GetVehicleInformations();

            return View(model);
        }

        // GET: VehicleInformation
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleInformation
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VehicleInformationCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new VehicleInformationService(userId);

            service.CreateVehicleInformation(model);

            return RedirectToAction("Index");
        }

        // GET: Delete
        // VehicleInformation/Delete/{id}
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleInformation vehicleInformation = _db.VehicleInformations.Find(id);
            if (vehicleInformation == null)
            {
                return HttpNotFound();
            }
            return View(vehicleInformation);
        }

        // POST: Delete
        // VehicleInformation/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            VehicleInformation vehicleInformation = _db.VehicleInformations.Find(id);
            _db.VehicleInformations.Remove(vehicleInformation);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Edit
        // VehicleInformation/Edit/{id}
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleInformation vehicleInformation = _db.VehicleInformations.Find(id);
            if (vehicleInformation == null)
            {
                return HttpNotFound();
            }
            return View(vehicleInformation);
        }

        // POST: Edit
        // VehicleInformation/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VehicleInformation vehicleInformation)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(vehicleInformation).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehicleInformation);
        }

        // GET: Details
        // VehicleInformation/Details/{id}
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleInformation vehicleInformation = _db.VehicleInformations.Find(id);
            if (vehicleInformation == null)
            {
                return HttpNotFound();
            }
            return View(vehicleInformation);
        }
    }
}