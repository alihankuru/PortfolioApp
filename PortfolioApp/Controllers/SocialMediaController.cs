using PortfolioApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioApp.Controllers
{
    public class SocialMediaController : Controller
    {
        PortfolioDBEntities db = new PortfolioDBEntities();
        public ActionResult Index()
        {
            var values = db.TblSocialMedia.ToList();
            return View(values);
        }


        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSocialMedia(TblSocialMedia p)
        {
            db.TblSocialMedia.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var value = db.TblSocialMedia.Find(id);
            db.TblSocialMedia.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");

        }


        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var values = db.TblSocialMedia.Find(id);
            return View(values);
        }


        [HttpPost]
        public ActionResult UpdateSocialMedia(TblSocialMedia p)
        {
            var value = db.TblSocialMedia.Find(p.SocialMediaId);
            value.Name = p.Name;
            value.Url = p.Url;
            value.Photo = p.Photo;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}