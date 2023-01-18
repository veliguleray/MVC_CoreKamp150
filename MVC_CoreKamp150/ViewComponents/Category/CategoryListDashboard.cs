using Businesslayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.ViewComponents.Category
{
    public class CategoryListDashboard:ViewComponent
    {

        CategoryManagerBL cm = new CategoryManagerBL(new EfCategoryRepositoryDAL());

        public IViewComponentResult Invoke()
        {
            var valCatgr = cm.TentityGetListBl();
            return View(valCatgr);
        }
    }
}
