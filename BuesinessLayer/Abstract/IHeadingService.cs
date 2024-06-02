using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BuesinessLayer.Abstract
{
	public interface IHeadingService
	{
		List<Heading> GetList();
		List<Heading> GetListByWriter(int id);
        void HeadingAdd(Heading heading);
		Heading GetByID(int id);
		void HeadingDelete(Heading heading);
		void HeadingUpdate(Heading heading);
	}
}
