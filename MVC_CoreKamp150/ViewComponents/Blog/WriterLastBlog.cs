using Businesslayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace A_MvcProje_UI.ViewComponents.Blog
{
	public class WriterLastBlog:ViewComponent
	{
		// parametreli Component kullanımı
		BlogManagerBL  bm = new BlogManagerBL(new EfBlogRepositoryDAL());

		public IViewComponentResult Invoke()
		{
			var valblog = bm.GetBlogListByWriterBL(2);

			return View(valblog);
		}
	}
}
