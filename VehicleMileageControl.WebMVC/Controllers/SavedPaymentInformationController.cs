using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VehicleMileageControl.Data;
using VehicleMileageControl.Model;

namespace VehicleMileageControl.WebMVC.Controllers
{
    [Authorize]
    public class SavedPaymentInformationController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: SavedPaymentInformation
        public ActionResult Index()
        {
            var model = new SavedPaymentInformationListItem[0];
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
        public ActionResult Create(SavedPaymentInformation savedPaymentInformation)
        {
            if (ModelState.IsValid)
            {
                _db.SavedPaymentInformations.Add(savedPaymentInformation);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(savedPaymentInformation);
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