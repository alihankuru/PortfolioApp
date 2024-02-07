using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioApp.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult SidePartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial() { 
        
            return PartialView();   
        }

        public PartialViewResult ScriptPartial()
        {

            return PartialView();

        }


    }
}