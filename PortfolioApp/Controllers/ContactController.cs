using PortfolioApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioApp.Controllers
{
    public class ContactController : Controller
    {
        PortfolioDBEntities db = new PortfolioDBEntities();
        // GET: Contact
        public ActionResult Index()
        {
            var values=db.TblContact.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult CreateMessage()
        {

            return View();

        }

        [HttpPost]
        public ActionResult CreateMessage(TblContact p)
        {
            db.TblContact.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");


        }

        public ActionResult DeleteMessage(int id)
        {
            var value=db.TblContact.Find(id);
            db.TblContact.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");


        }




    }
}