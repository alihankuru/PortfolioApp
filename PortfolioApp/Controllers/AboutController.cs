using PortfolioApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioApp.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        PortfolioDBEntities db = new PortfolioDBEntities();
        public ActionResult Index()
        {
            var values=db.TblAbout.ToList();

            return View(values);
        }


        //public ActionResult DeleteAbout(int id)
        //{
        //    var value = db.TblAbout.Find(id);
        //    db.TblAbout.Remove(value);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");

        //}

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {

            var value = db.TblAbout.Find(id);
            return View(value);


        }

        [HttpPost]
        public ActionResult UpdateAbout(TblAbout p)
        {
            var value = db.TblAbout.Find(p.AboutID);
            value.Title = p.Title;
            value.Description = p.Description;
            value.Header = p.Header;
            value.ImageUrl = p.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");

        }









    }



}