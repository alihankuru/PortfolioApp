using PortfolioApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioApp.Controllers
{
    public class WebLayoutController : Controller
    {
        PortfolioDBEntities db = new PortfolioDBEntities();
        // GET: WebLayout
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult PageNavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult AboutSectionPartial()
        {
            var values = db.TblAbout.ToList();

            return PartialView(values);
        }

        public PartialViewResult ServiceSectionPartial()
        {
            var values = db.TblService.ToList();
            
            return PartialView(values);
        }

        public PartialViewResult PortfolioSectionPartial()
        {

            return PartialView();
        }

        public PartialViewResult PricingSectionPartial()
        {

            return PartialView();
        }

        public PartialViewResult SectionPartial()
        {

            return PartialView();
        }

        public PartialViewResult TestimonialPartial()
        {

            return PartialView();
        }

        public PartialViewResult BlogSectionPartial()
        {

            return PartialView();
        }

        public PartialViewResult ContactSectionPartial()
        {

            return PartialView();
        }

        public PartialViewResult FooterSectionPartial()
        {

            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {

            return PartialView();
        }


    }
}