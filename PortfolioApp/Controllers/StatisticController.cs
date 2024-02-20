using PortfolioApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioApp.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic

        PortfolioDBEntities db = new PortfolioDBEntities();
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount= db.TblProject.Count();

            ViewBag.skillCount=db.TblSkill.Count();
            ViewBag.skillAverage = db.TblSkill.Average(X => X.value);
            ViewBag.lastSkillTitleName = db.GetLastSkillTitle().FirstOrDefault();
            
            ViewBag.coreCategoryProjectCount=db.TblProject.Where(x=>x.ProjectCategory==1002).Count();
            ViewBag.socialMediaCount = db.TblSocialMedia.Count();
            ViewBag.testimonialCount = db.TblTestmonial.Count();
            ViewBag.lastProjectName = db.GetLastProjectName().FirstOrDefault();
            ViewBag.ContactCount=db.TblContact.Count();


            return View();
        }
    }
}