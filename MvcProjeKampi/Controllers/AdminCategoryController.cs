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
	public class AdminCategoryController : Controller
	{
		// GET: AdminCategory
		CategoryManager cm = new CategoryManager(new EfCategoryDal());
		public ActionResult Index()
		{
			var model = cm.GetList();
			return View(model);
		}
		public ActionResult AddCategory()
		{
			return View();
		}
		[HttpPost]
		public ActionResult AddCategory(Category p)
		{
			CategoryValidator validator = new CategoryValidator();
			ValidationResult result = validator.Validate(p);
			if (result.IsValid)
			{
				cm.CategoryAdd(p);
				return RedirectToAction("Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}

		public ActionResult DeleteCategory(int id)
		{
			var categoryValue = cm.GetByID(id);
			cm.CategoryRemove(categoryValue);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public ActionResult EditCategory(int id)
		{
			var vategoryValue = cm.GetByID(id);
			return View(vategoryValue);
		}
		[HttpPost]
		public ActionResult EditCategory(Category p)
		{
			cm.CategoryUpdate(p);
			return RedirectToAction("Index");
		}
	}
}