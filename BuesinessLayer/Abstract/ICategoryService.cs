﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuesinessLayer.Abstract
{
	public interface ICategoryService
	{
		List<Category> GetList();
		void CategoryAdd(Category category);
		Category GetByID(int id);
		void CategoryRemove(Category category);
		void CategoryUpdate(Category category);
	}
}
