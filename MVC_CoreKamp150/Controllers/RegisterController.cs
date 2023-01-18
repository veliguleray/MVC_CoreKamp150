using Businesslayer.Concrete;
using Businesslayer.ValidationRules;
using DataAccessLayer.Entityframework;
using Entitylayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.Controllers
{
	public class RegisterController : Controller
	{
		WriterManagerBL wm = new WriterManagerBL( new EfWriterRepositoryDAL());


		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index( Writer p)
		{ 
			//fluentValidatıon için
			WriterValidator wv= new WriterValidator();
			ValidationResult results= wv.Validate(p);

			if (results.IsValid)  // eğer doğrulama gecerli ise
			{
                p.WriterStatus = true;     // yazar kayıt sırasında hatta almamak için burada ekleme yapıldı
                p.WriterAbout = "Deneme"; // yazar kayıt sırasında hatta almamak için burada ekleme yapıldı
                p.WriterImage = "image";
                wm.TentityInsertBl(p);

                return RedirectToAction("Index", "Blog");

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
	}
}
