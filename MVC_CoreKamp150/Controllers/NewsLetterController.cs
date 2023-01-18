using Businesslayer.Concrete;
using DataAccessLayer.Entityframework;
using Entitylayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.Controllers
{
	public class NewsLetterController : Controller
	{
		// ödev 39
		NewsLetterManagerBL nm = new NewsLetterManagerBL( new EfNewsLetterRepositoryDAL());
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}

		[HttpPost]
		public PartialViewResult SubscribeMail(NewsLetter p)
		{
			p.MailStatus = true;
			nm.NewsLetterInsertBl(p);
			return PartialView ("SubscribeMail");
		}
	}
}
