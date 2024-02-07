using PortfolioApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioApp.Controllers
{
    public class TestmonialController : Controller
    {
        // GET: Testmonial
        PortfolioDBEntities db = new PortfolioDBEntities();
        public ActionResult Index()
        {
            var value = db.TblTestmonial.ToList();

            return View(value);
        }


        [HttpGet]
        public ActionResult CreateTestmonial() {
        
            return View();
            
        }


        [HttpPost]
        public ActionResult CreateTestmonial(TblTestmonial p)
        {

            db.TblTestmonial.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");

        }


        [HttpGet]
        public ActionResult UpdateTestmonial(int id)
        {

            var value = db.TblTestmonial.Find(id);
            return View(value);


        }

        [HttpPost]
        public ActionResult UpdateTestmonial(TblTestmonial p)
        {
            var value = db.TblTestmonial.Find(p.TestmonialId);
            value.NameSurname = p.NameSurname;
            value.Description=p.Description;
            value.ImageUrl = p.ImageUrl;    

            db.SaveChanges();
            return RedirectToAction("Index");



        }




        public ActionResult DeleteTestmonial(int id)
        {
            var value = db.TblTestmonial.Find(id);
            db.TblTestmonial.Remove(value);
            db.SaveChanges();


            return RedirectToAction("Index");

        }




    }
}