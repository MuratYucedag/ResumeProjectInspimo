using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class ContactController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }

        public ActionResult DeleteMessage(int id)
        {
            var values = db.TblContact.Find(id);
            db.TblContact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
