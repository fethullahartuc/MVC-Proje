using BuesinessLayer.Concrete;
using BuesinessLayer.ValidationRules;
using DataAccessLayer.Entityramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager mm = new MessageManager(new EfMessageDal());
        MessageValidator validator = new MessageValidator();
		[Authorize]
        public ActionResult Inbox()
        {
            var model = mm.GetListInbox();
            return View(model);
        }
        public ActionResult Sendbox()
        {
            var model = mm.GetListSendbox();
            return View(model);
        }

		public ActionResult GetInBoxMessageDetails(int id)
		{
			var value = mm.GetByID(id);
			return View(value);
		}
		public ActionResult GetSendBoxMessageDetails(int id)
		{
			var value = mm.GetByID(id);
			return View(value);
		}

		[HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
		[HttpPost]
		public ActionResult NewMessage(Message p)
		{

			ValidationResult results = validator.Validate(p);
			if (results.IsValid)
			{
				p.MessageDate=DateTime.Parse(DateTime.Now.ToShortDateString());
				mm.MessageAdd(p);
				return RedirectToAction("SendBox");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}

			return View();
		}

	}
}