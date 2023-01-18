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
    public class BlogManagerBL : IBlogServiceBL
    {
        IBlogDAL _blogDAL;

		public BlogManagerBL(IBlogDAL blogDAL)
		{
			_blogDAL = blogDAL;
		}

        public void TentityInsertBl(Blog t)
        {
            _blogDAL.InsertDAL(t);
        }

        public void TentityDeleteBl(Blog t)
        {
            _blogDAL.DeleteDAL(t);
        }

        public void TentityUpdateBl(Blog t)
        {
            _blogDAL.UpdateDAL(t);
        }

        public List<Blog> TentityGetListBl()
        {
            return _blogDAL.GetListAllDAL();
        }

        public Blog TentityGetByIdBL(int id)
        {
            return _blogDAL.GetByIdDAL(id);

        }

        public List<Blog> GetListWithCategoryBL()
        {
            return _blogDAL.GetListWithCategoryDAL();
        }

        //57 sarta baslı
        public List<Blog> GetListWithCategoryByWriterBmBL(int id)
        {
            return _blogDAL.GetListWithCategoryByWriterDAL(id);  //bunun IBlogServicede Karsılıgı yok
        }

        public List<Blog> GetBlogListByWriterBL(int id)
        {
            //37v
            return _blogDAL.GetListAllDAL(x => x.WriterID == id);
        }


        public List<Blog> GetLast3Blog() //49v da eklendi sadece managerde var servicede yok
        {
            // footer alanında son 3 blogu getırmek ıcın
            return _blogDAL.GetListAllDAL().Take(3).ToList();
        }

        public List<Blog> BlogGetByIdListBl(int id)//aynı ısım old ıcın BlogServicede karsılıgı yok
        {
            return _blogDAL.GetListAllDAL(x => x.BlogId == id);
        }
    }
}
