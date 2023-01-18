using Entitylayer.Concrete;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Abstract
{
    public interface IBlogServiceBL:IGenericServiceBL<Blog>
    {

    //    void BlogInsertBl(Blog blog);
    //    void BlogDeleteBl(Blog blog);
    //    void BlogUpdateBl(Blog blog);

    //    List<Blog> BlogGetListBl();

    //    Blog BlogGetByIdBL(int id);

        //Blog litesinde Categorı Adını Cagırmak ıcın metot tanımladık
        List<Blog> GetListWithCategoryBL();
        
        // 37v
		List<Blog> GetBlogListByWriterBL( int id);

	}
}
