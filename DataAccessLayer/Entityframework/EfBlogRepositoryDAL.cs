using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Entitylayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entityframework
{
	public class EfBlogRepositoryDAL : GenericRepositoryDAL<Blog>, IBlogDAL
	{
        // ilk metotları GenericRepository den alıyor

        public List<Blog> GetListWithCategoryDAL()
		{
			using(var db=new Context())
			{
				//return db.Blogs.ToList();  yerine İnclude Metodu gelecek

				return db.Blogs.Include(x=>x.Category).ToList();
			}
		}

        public List<Blog> GetListWithCategoryByWriterDAL(int id)
        {
            using (var db = new Context())
            {
                
                //57 sarta baglı 
                return db.Blogs.Include(x => x.Category).Where(x=>x.WriterID==id).ToList();
            }
        }
    }
}
