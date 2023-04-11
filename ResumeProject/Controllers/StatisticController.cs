using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class StatisticController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            //ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.countProjeTalebi = db.CountProjeTalebi().FirstOrDefault();
            ViewBag.technologyCount = db.TblTechnology.Count();
            ViewBag.csharpValue = db.TblTechnology.Where(x => x.TechnologyITitle == "C#").Select(y => y.TechnologyIValue).FirstOrDefault();
            ViewBag.contactCount = db.TblContact.Count();
            ViewBag.subjectTesekkur = db.TblContact.Where(x => x.Subject == 1).Count();
            ViewBag.sumTechnologyValue = db.TblTechnology.Sum(x => x.TechnologyIValue);
            ViewBag.averageTechnologyValue = db.TblTechnology.Average(x => x.TechnologyIValue);
            ViewBag.GetBy3ID = db.TblSkill.Where(x => x.SkillID == 3).Select(y => y.SkillTitle).FirstOrDefault();
            ViewBag.maxTechnologyValue = db.TblTechnology.Max(x => x.TechnologyIValue);
            return View();
        }
    }
}