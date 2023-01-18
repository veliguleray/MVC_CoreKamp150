using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.Controllers
{
	   // [Authorize] // tüm IActionResult ıcın
	public class WriterController : Controller
	{
		//[Authorize] sadece 1 tane icin

		// [AllowAnonymous] //gecici olarak benı muaf tut //48 kaldırdık
		public IActionResult Index()
		{
			return View();
		}
		

		public IActionResult WriterProfile()
		{
			return View();
		}
		

		public IActionResult WriterMail()
		{
			return View();
		}

		[AllowAnonymous]
		public IActionResult test()
		{
			return View();
		}
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
		{

			return PartialView();
		}
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {

            return PartialView();
        }
    }
}
