using Businesslayer.Concrete;
using Businesslayer.ValidationRules;
using DataAccessLayer.Entityframework;
using Entitylayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace A_MvcProje_UI.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManagerBL bm = new BlogManagerBL(new EfBlogRepositoryDAL());
        public IActionResult Index()
        {

            var valBlg = bm.GetListWithCategoryBL();

            return View(valBlg);
        }
        public IActionResult BlogReadAll(int id)
        {

            ViewBag.i = id;
            var valblog = bm.BlogGetByIdListBl(id);

            return View(valblog);
        }
        public IActionResult BlogListByWriter()
        {
            var valxxx = bm.GetListWithCategoryByWriterBmBL(2);  //57 sarta baglı
            return View(valxxx);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            // DDList Category için

            CategoryManagerBL cm = new CategoryManagerBL(new EfCategoryRepositoryDAL());

            List<SelectListItem> valDDL = (from item in cm.TentityGetListBl()
                                           select new SelectListItem
                                           {
                                               Text=item.CategoryName,
                                               Value=item.CategoryID.ToString()

                                           }).ToList();


            ViewBag.cv = valDDL;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            //fluentValidatıon için
            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(p);

            if (results.IsValid)  // eğer doğrulama gecerli ise
            {
                p.BlogStatus = true; // yazar kayıt sırasında hatta almamak için burada ekleme yapıldı
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID = 2;
                bm.TentityInsertBl(p);

                return RedirectToAction("BlogListByWriter", "Blog");

            }
            else
            {
                // varsa hataları ve sebeblerini gostermek için FOREACH kullan
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }

            }

            return View();
        }

        public IActionResult DeleteBlog(int id)
        {
            var valSilBlg = bm.TentityGetByIdBL(id); //önce İd ye gore bulacak
            bm.TentityDeleteBl(valSilBlg);

            return RedirectToAction("BlogListByWriter");

        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var valblog=bm.TentityGetByIdBL(id); //once bulalım

            // DDList Category için

            CategoryManagerBL cm = new CategoryManagerBL(new EfCategoryRepositoryDAL());

            List<SelectListItem> valDDL = (from item in cm.TentityGetListBl()
                                           select new SelectListItem
                                           {
                                               Text = item.CategoryName,
                                               Value = item.CategoryID.ToString()

                                           }).ToList();


            ViewBag.cv = valDDL;
            return View(valblog);
        }

        [HttpPost]
        public IActionResult EditBlog( Blog p)
        {
            p.WriterID = 2;
            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.BlogStatus = true; //hataların onune gecmek ıcın

            bm.TentityUpdateBl(p);

            return View("BlogListByWriter");
        }


    }
}
