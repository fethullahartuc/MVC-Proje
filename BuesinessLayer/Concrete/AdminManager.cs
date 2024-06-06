using BuesinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuesinessLayer.Concrete
{
	public class AdminManager : IAdminService
	{
		IAdminDal _adminDal;


		public AdminManager(IAdminDal adminDal)
		{
			_adminDal = adminDal;
		}

        public void AdminAdd(Admin admin)
        {
           _adminDal.Insert(admin);
        }

        public void AdminDelete(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void AdminUpdate(Admin admin)
        {
            _adminDal.Update(admin);
        }

        public Admin Get(string username, string password)
		{
			return _adminDal.Get(x => x.AdminUserName.Equals(username) && x.AdminPassword.Equals(password));
		}

        public Admin GetByID(int id)
        {
            return _adminDal.Get(x => x.AdminId == id);
        }

        public List<Admin> GetList()
        {
            return _adminDal.List();
        }
    }
}
