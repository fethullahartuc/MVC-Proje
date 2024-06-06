using BuesinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entityramework;
using EntityLayer.Concrete;
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
            var value = cm.GetList(null);
            return View(value);
        }
        Context c = new Context();
        public ActionResult GetAllContent(string p="")
        {
            var values = cm.GetList(p);

            //var values = c.Contents.ToList(); 
            return View(values.ToList());
        }
		public ActionResult ContentByHeading(int id)
		{
            var contentValue = cm.GetListByHeadingID(id);
			return View(contentValue);
		}
        
    }
}