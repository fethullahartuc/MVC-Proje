using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuesinessLayer.Abstract
{
	public interface IAdminService
	{
		Admin Get(string username,string password);
	}
}
