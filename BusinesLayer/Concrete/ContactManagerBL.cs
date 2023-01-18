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
    public class ContactManagerBL : IContactServiceBL
    {
        IContactDAL _contactDAL;

		public ContactManagerBL(IContactDAL contactDAL)
		{
			_contactDAL = contactDAL;
		}

		public void ContactDeleteBl(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Contact ContactGetByIdBL(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> ContactGetListBl()
        {
            throw new NotImplementedException();
        }

        public void ContactInsertBl(Contact contact)
        {
            _contactDAL.InsertDAL(contact);
        }

        public void ContactUpdateBl(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void TentityDeleteBl(Contact t)
        {
            throw new NotImplementedException();
        }

        public Contact TentityGetByIdBL(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> TentityGetListBl()
        {
            throw new NotImplementedException();
        }

        public void TentityInsertBl(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TentityUpdateBl(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
