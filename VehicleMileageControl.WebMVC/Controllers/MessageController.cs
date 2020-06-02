using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VehicleMileageControl.Data;
using VehicleMileageControl.Model.MessageModel;

namespace VehicleMileageControl.WebMVC.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Message
        public ActionResult Index()
        {
            var model = new MessageListItem[0];
            return View(model);
        }
        // GET: Delete
        // Message/Delete/{id}
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Message message = _db.Messages.Find(id);
            if (message == null)
            {
                return HttpNotFound();
            }
            return View(message);
        }

        // POST: Delete
        // Message/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Message message = _db.Messages.Find(id);
            _db.Messages.Remove(message);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET: Details
        // Message/Details/{id}
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Message message = _db.Messages.Find(id);
            if (message == null)
            {
                return HttpNotFound();
            }
            return View(message);
        }
    }
}