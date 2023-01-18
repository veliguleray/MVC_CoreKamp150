using A_MvcProje_UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var valCom = new List<UserComment>
            {
                new UserComment
                {
                    Id= 1,
                    UserName="ALİ"
                },
                new UserComment
                {
                    Id= 2,
                    UserName="İDİl"
                },
                 new UserComment
                {
                    Id= 3,
                    UserName="AZAD"
                }

            };



             return View(valCom);
        }
    }
        
}
