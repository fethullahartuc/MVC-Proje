﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuesinessLayer.Abstract
{
	public interface IContentService
	{
		List<Content> GetList(string p);
		List<Content> GetListByWriter(int id);
        List<Content> GetListByHeadingID(int id);
		void ContentAdd(Content content);
		Content GetByID(int id);
		void ContentRemove(Content content);
		void ContentUpdate(Content content);
	}
}
