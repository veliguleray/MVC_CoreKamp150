using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDAL : IGenericDAL<Blog>
    {
		// blog içindeki Categorı Adını Lıstemek için
		// buraya yenı metot tanımladık

		List<Blog> GetListWithCategoryDAL();

		//57
		List<Blog> GetListWithCategoryByWriterDAL( int id);


	}
}
