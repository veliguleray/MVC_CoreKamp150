using Businesslayer.Concrete;
using DataAccessLayer.Entityframework;
using Entitylayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.Controllers
{
	public class ContactController : Controller
	{
		ContactManagerBL cm = new ContactManagerBL( new EfContactRepositoryDAL());

		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index( Contact p)
		{
			p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.ContactStatus = true;
			cm.ContactInsertBl(p);
		    return RedirectToAction ("Index","Blog");
		}
	}
}
