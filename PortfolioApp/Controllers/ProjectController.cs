using PortfolioApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Web.WebPages.Html;

namespace PortfolioApp.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        PortfolioDBEntities db = new PortfolioDBEntities();
        public ActionResult Index()
        {
            var values=db.TblProject.ToList();
            return View(values);
        }



        public ActionResult CreateProject()
        {
            List<System.Web.Mvc.SelectListItem> values = (from x in db.TblCategory.ToList()
                                           select new System.Web.Mvc.SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.CategoryId.ToString(),
                                           }).ToList();
            ViewBag.v = values;


            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(TblProject p)
        {
            db.TblProject.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult DeleteProject(int id)
        {
            var value=db.TblProject.Find(id);
            db.TblProject.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");

        }


        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var value= db.TblProject.Find(id);
            List<System.Web.Mvc.SelectListItem> values=(from x in db.TblCategory.ToList()
                                         select new System.Web.Mvc.SelectListItem
                                         {
                                             Text=x.Name,
                                             Value = x.CategoryId.ToString(),
                                         }).ToList();

            ViewBag.v=values;

            return View(value);

        }


        [HttpPost]
        public ActionResult UpdateProject(TblProject p)
        {
            var value = db.TblProject.Find(p.ProjectId);
            value.Title = p.Title;
            value.Description = p.Description;
            value.ImageUrl = p.ImageUrl;
            value.ProjectUrl = p.ProjectUrl;
            value.ProjectCategory = p.ProjectCategory;
            db.SaveChanges();
            return RedirectToAction("Index");


        }




    }
}