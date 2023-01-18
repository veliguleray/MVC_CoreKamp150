using Businesslayer.Abstract;
using DataAccessLayer.Abstract;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Concrete
{
    public class AboutManagerBL : IAboutServiceBL
    {
        IAboutDAL _aboutDAL;

		public AboutManagerBL(IAboutDAL aboutDAL)
		{
			_aboutDAL = aboutDAL;
		}

        public void TentityDeleteBl(About t)
        {
            throw new NotImplementedException();
        }

        public About TentityGetByIdBL(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TentityGetListBl()
        {
            return _aboutDAL.GetListAllDAL();
        }

        public void TentityInsertBl(About t)
        {
            throw new NotImplementedException();
        }

        public void TentityUpdateBl(About t)
        {
            throw new NotImplementedException();
        }

        
    }
}
