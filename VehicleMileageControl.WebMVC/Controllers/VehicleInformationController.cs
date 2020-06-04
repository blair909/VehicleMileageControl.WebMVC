using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VehicleMileageControl.Data;
using VehicleMileageControl.Model.VehicleInformation;
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
        // GET: Delete
        // VehicleInformation/Delete/{id}
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleInformation maintenance = _db.VehicleInformations.Find(id);
            if (maintenance == null)
            {
                return HttpNotFound();
            }
            return View(maintenance);
        }

        // POST: Delete
        // VehicleInformation/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            VehicleInformation maintenance = _db.VehicleInformations.Find(id);
            _db.VehicleInformations.Remove(maintenance);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}