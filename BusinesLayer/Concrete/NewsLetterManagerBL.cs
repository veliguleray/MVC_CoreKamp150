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
	public class NewsLetterManagerBL : INewsLetterServiceBL
	{
		INewsletterDAL _newsletterDAL;

		public NewsLetterManagerBL(INewsletterDAL newsletterDAL)
		{
			_newsletterDAL = newsletterDAL;
		}

		public void NewsLetterDeleteBl(NewsLetter newsLetter)
		{
			throw new NotImplementedException();
		}

		public NewsLetter NewsLetterGetByIdBL(int id)
		{
			throw new NotImplementedException();
		}

		public List<NewsLetter> NewsLetterGetListBl()
		{
			throw new NotImplementedException();
		}

		public void NewsLetterInsertBl(NewsLetter newsLetter)
		{
			_newsletterDAL.InsertDAL(newsLetter);
		}

		public void NewsLetterUpdateBl(NewsLetter newsLetter)
		{
			throw new NotImplementedException();
		}

        public void TentityDeleteBl(NewsLetter t)
        {
            throw new NotImplementedException();
        }

        public NewsLetter TentityGetByIdBL(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> TentityGetListBl()
        {
            throw new NotImplementedException();
        }

        public void TentityInsertBl(NewsLetter t)
        {
            throw new NotImplementedException();
        }

        public void TentityUpdateBl(NewsLetter t)
        {
            throw new NotImplementedException();
        }
    }
}
