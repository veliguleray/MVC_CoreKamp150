using Businesslayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManagerBL cm = new CategoryManagerBL( new EfCategoryRepositoryDAL());
        public IActionResult Index()
        {
            var vallistele=cm.TentityGetListBl();

            return View(vallistele);
        }
    }
}
