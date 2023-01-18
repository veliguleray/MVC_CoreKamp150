using Businesslayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        CommentManagerBL cm = new CommentManagerBL(new EfCommentRepositoryDAL());

        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
