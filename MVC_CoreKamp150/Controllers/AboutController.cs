using Businesslayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.Controllers
{
	public class AboutController : Controller
	{
		AboutManagerBL abm = new AboutManagerBL(new EfAboutRepositoryDAL());
		public IActionResult Index()
		{
			var valxd = abm.TentityGetListBl();
			return View(valxd);
		}
		public PartialViewResult SocialMediaAbout()
		{
			

			return PartialView();
		}
	}
}
