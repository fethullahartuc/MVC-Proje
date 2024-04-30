using BuesinessLayer.Concrete;
using DataAccessLayer.Entityramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutManager abm = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var model = abm.GetList();
            return View(model);
        }
        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }
		[HttpPost]
		public ActionResult AddAbout(About p)
		{
            abm.AboutAdd(p);
			return RedirectToAction("Index");
		}

        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }
	}
}