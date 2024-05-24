using BuesinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entityramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjeKampi.Controllers
{
    public class LoginController : Controller
    {
        AdminManager adm = new AdminManager(new EfAdminDal());
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
		public ActionResult Index(Admin p)
		{
            var value = adm.Get(p.AdminUserName,p.AdminPassword);
            if (value != null)
            {
                FormsAuthentication.SetAuthCookie(value.AdminUserName,false);
                Session["AdminUserName"]=value.AdminUserName;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            { 
                return RedirectToAction("Index");
            }
		}
	}
}