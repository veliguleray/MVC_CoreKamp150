using Businesslayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.ViewComponents.Blog
{
	public class BlogLast3Post : ViewComponent
	{
		// parametreli Component kullanımı
		BlogManagerBL bm = new BlogManagerBL(new EfBlogRepositoryDAL());

		public IViewComponentResult Invoke()
		{
			var valblog = bm.GetLast3Blog();

			return View(valblog);
		}


	}

	
}
