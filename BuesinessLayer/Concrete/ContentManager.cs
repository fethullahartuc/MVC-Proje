﻿using BuesinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuesinessLayer.Concrete
{
	public class ContentManager : IContentService
	{
		IContentDal _contentDal;

		public ContentManager(IContentDal contentDal)
		{
			_contentDal = contentDal;
		}

		public void ContentAdd(Content content)
		{
			throw new NotImplementedException();
		}

		public void ContentRemove(Content content)
		{
			throw new NotImplementedException();
		}

		public void ContentUpdate(Content content)
		{
			throw new NotImplementedException();
		}

		public Content GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Content> GetList()
		{
			return _contentDal.List();
		}

		public List<Content> GetListByHeadingID(int id)
		{
			return _contentDal.List(x=>x.HeadingID==id);
		}
	}
}
