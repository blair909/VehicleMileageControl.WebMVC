using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VehicleMileageControl.Data;
using VehicleMileageControl.Model.VehicleInformation;

namespace VehicleMileageControl.WebMVC.Controllers
{
    public class VehicleInformationController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: VehicleInformation
        public ActionResult Index()
        {
            var model = new VehicleInformationListItem[0];
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
    }
}