using Businesslayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.ViewComponents.Writer
{
 
    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManagerBL wm = new WriterManagerBL( new EfWriterRepositoryDAL());
        public IViewComponentResult Invoke()
        {
            var valxx = wm.GetWriterByIdBL(1);
            

            return View(valxx);
        }

    }
}
