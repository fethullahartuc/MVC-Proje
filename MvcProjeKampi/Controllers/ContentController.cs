using BuesinessLayer.Concrete;
using DataAccessLayer.Entityramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult Index()
        {
            var value = cm.GetList();
            return View(value);
        }
		public ActionResult ContentByHeading(int id)
		{
            var contentValue = cm.GetListByHeadingID(id);
			return View(contentValue);
		}
	}
}