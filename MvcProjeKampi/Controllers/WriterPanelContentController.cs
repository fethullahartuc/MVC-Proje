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
    public class WriterPanelContentController : Controller
    {
        Context c   = new Context();
        // GET: WriterPanelContent
        ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult MyContent(string p)
        {
            
            p = (string)Session["WriterMail"];
            //ViewBag.d = p;
            var writeridinfo = c.Writers.Where(b => b.WriterMail == p).Select(y=>y.WriterID).FirstOrDefault();
            var contentValue = cm.GetListByWriter(writeridinfo);
            return View(contentValue);
        }
        [HttpGet]
        public ActionResult AddContent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddContent(Content p)
        {
            string mail = (string)Session["WriterMail"];
            //ViewBag.d = p;
            var writeridinfo = c.Writers.Where(b => b.WriterMail == mail).Select(y => y.WriterID).FirstOrDefault();
            p.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterID = writeridinfo;
            p.ContentStatus =true;
            cm.ContentAdd(p);
            return RedirectToAction("MyContent");
        }
    }
}

