using PortfolioApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioApp.Controllers
{
    public class DefaultController : Controller
    {
        PortfolioDBEntities db = new PortfolioDBEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }


        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult FeaturePartial()
        {
            var values= db.TblFeature.ToList();
            return PartialView(values);
        }

        public PartialViewResult ProfilePartial()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }

        public PartialViewResult SkillPartial()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }

        public PartialViewResult AboutPartial()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }

        public PartialViewResult ServicePartial()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }

        public PartialViewResult WidgetPartial()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.socialMediaCount = db.TblSocialMedia.Count();
            ViewBag.skillCount = db.TblSkill.Count();

            return PartialView();
        }

        public PartialViewResult ProjectPartial()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }

        public PartialViewResult TestmonialPartial()
        {
            var values = db.TblTestmonial.ToList();
            return PartialView(values);
        }

        [HttpGet]
        public PartialViewResult ContactPartial()
        {
            
            return PartialView();
        }


        [HttpPost]
        public PartialViewResult ContactPartial(TblContact p)
        {
            p.Date = DateTime.Now;
            db.TblContact.Add(p);
            db.SaveChanges();
            return PartialView();
        }


        public PartialViewResult ScriptPartial()
        {
            
            return PartialView();
        }




    }
}