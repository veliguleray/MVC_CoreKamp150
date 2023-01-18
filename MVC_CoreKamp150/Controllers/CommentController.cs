using Businesslayer.Concrete;
using DataAccessLayer.Entityframework;
using Entitylayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.Controllers
{
	public class CommentController : Controller
	{
		CommentManagerBL cm = new CommentManagerBL( new EfCommentRepositoryDAL());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult PartialAddComment(Comment p)
        {
			p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.CommentStatus = true;
			p.BlogId = 3;
			cm.CommentInsertBl(p);
            return PartialView(); 
        }
        public PartialViewResult CommentListByBlog( int id)
		{
			var valCom = cm.CommentGetListBl(id);
			return PartialView(valCom);
		}
	}
}
