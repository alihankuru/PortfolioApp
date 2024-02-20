using PortfolioApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioApp.Controllers
{
    public class ProfileController : Controller
    {
        // GET: About
        PortfolioDBEntities db = new PortfolioDBEntities();
        public ActionResult Index()
        {
            var values = db.TblProfile.ToList();

            return View(values);
        }


        

        [HttpGet]
        public ActionResult UpdateProfile(int id)
        {

            var value = db.TblProfile.Find(id);
            return View(value);


        }

        [HttpPost]
        public ActionResult UpdateProfile(TblProfile p)
        {
            var value = db.TblProfile.Find(p.ProfileId);
            value.NameSurname = p.NameSurname;
            value.Profile = p.Profile;
            value.Email = p.Email;
            value.Phone = p.Phone;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}