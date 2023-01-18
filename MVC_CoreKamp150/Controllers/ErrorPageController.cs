using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1( int code)
        {
            return View();
        }
    }
}
