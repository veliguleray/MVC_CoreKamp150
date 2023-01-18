using Businesslayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.Controllers
{
    public class DashboardController : Controller
    {
        
        BlogManagerBL bm = new BlogManagerBL( new EfBlogRepositoryDAL());
        public IActionResult Index()
        {
            //70
            Context db= new Context(); // bunu yazarken SOLİD i ezdik Neden? ezmeden nasıl yaparız?
            ViewBag.v1=db.Blogs.Count().ToString();   //toplam blog sayısı
            ViewBag.v2=db.Blogs.Where(x=>x.WriterID==1).Count(); //sizin blog sayınız
            ViewBag.v3=db.Categories.Count().ToString();   // toplam categorı sayısı

            return View();
        }

    }
}
