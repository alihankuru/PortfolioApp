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

    }
}