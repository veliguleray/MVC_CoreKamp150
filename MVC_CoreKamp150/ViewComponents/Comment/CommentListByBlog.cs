using Businesslayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;

namespace A_MvcProje_UI.ViewComponents.Comment
{
    public class CommentListByBlog:ViewComponent
    {
        CommentManagerBL cm = new CommentManagerBL( new EfCommentRepositoryDAL());

        public IViewComponentResult Invoke(int id)
        {
            var valCom = cm.CommentGetListBl(id);
            return View(valCom);
        }
    }
}
