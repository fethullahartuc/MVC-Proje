using BuesinessLayer.Concrete;
using BuesinessLayer.ValidationRules;
using DataAccessLayer.Entityramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
	public class ContactController : Controller
	{
		// GET: Contact
		ContactManager cm = new ContactManager(new EfContactDal());
		ContactValidator validator = new ContactValidator();
		public ActionResult Index()
		{
			var model = cm.List();
			return View(model);
		}

		public ActionResult GetContactDetails(int id)
		{
			var value = cm.GetByID(id);
			return View(value);
		}
		public PartialViewResult MessageListMenu()
		{
			return PartialView();
		}
	}
}