using DataAccessLayer.Abstract;
using DataAccessLayer.Entityramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuesinessLayer.Concrete
{
	public class ImageFileManager : IImageFileService
	{
		IImageFileDal imageFileDal;

		public ImageFileManager(IImageFileDal imageFileDal)
		{
			this.imageFileDal = imageFileDal;
		}

		public List<ImageFile> GetList()
		{
			return imageFileDal.List();
		}
	}
}
