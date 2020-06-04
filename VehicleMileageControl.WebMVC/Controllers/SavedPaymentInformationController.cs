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
    public class SavedPaymentInformationController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: SavedPaymentInformation
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new SavedPaymentInformationService(userId);
            var model = service.GetPayment();

            return View(model);
        }

        // GET: SavedPaymentInformation
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: SavedPaymentInformation
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SavedPaymentInformationCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new SavedPaymentInformationService(userId);

            service.CreatePayment(model);

            return RedirectToAction("Index");
        }

        // GET: Delete
        // SavedPaymentInformation/Delete/{id}
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SavedPaymentInformation savedPaymentInformation = _db.SavedPaymentInformations.Find(id);
            if (savedPaymentInformation == null)
            {
                return HttpNotFound();
            }
            return View(savedPaymentInformation);
        }

        // POST: Delete
        // SavedPaymentInformation/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            SavedPaymentInformation savedPaymentInformation = _db.SavedPaymentInformations.Find(id);
            _db.SavedPaymentInformations.Remove(savedPaymentInformation);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Edit
        // SavedPaymentInformation/Edit/{id}
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SavedPaymentInformation savedPaymentInformation = _db.SavedPaymentInformations.Find(id);
            if (savedPaymentInformation == null)
            {
                return HttpNotFound();
            }
            return View(savedPaymentInformation);
        }

        // POST: Edit
        // SavedPaymentInformation/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SavedPaymentInformation savedPaymentInformation)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(savedPaymentInformation).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(savedPaymentInformation);
        }

        // GET: Details
        // SavedPaymentInformation/Details/{id}
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SavedPaymentInformation savedPaymentInformation = _db.SavedPaymentInformations.Find(id);
            if (savedPaymentInformation == null)
            {
                return HttpNotFound();
            }
            return View(savedPaymentInformation);
        }
    }
}