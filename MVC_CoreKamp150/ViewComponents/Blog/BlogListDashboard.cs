using Businesslayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.ViewComponents.Blog
{
    public class BlogListDashboard:ViewComponent
    {
        BlogManagerBL bm = new BlogManagerBL(new EfBlogRepositoryDAL());

        public IViewComponentResult Invoke()
        {
            var val = bm.GetListWithCategoryBL();
            return View(val); 
        }

    }
}
