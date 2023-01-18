using DataAccessLayer.Concrete;
using Entitylayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;
using System.Security.Claims;

namespace A_MvcProje_UI.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]  // beni Authorize den SADECE Burası İçin MUAF tut
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
		[AllowAnonymous]  // beni Authorize den SADECE Burası İçin MUAF tut
		public async Task<IActionResult> Index( Writer p)
		{
			//48v
			Context c = new Context();
			var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);

			if (datavalue != null)
			{
				//taleplerimiz
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name,p.WriterMail)
				};
				var useridentity = new ClaimsIdentity(claims, "a");  // neden burada bır deger gondermem gerekıyor? a  b  c gibi ?
				ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);

				await HttpContext.SignInAsync(principal);  // gelen değeri şifreli formatta cooki olsturmk için  
				return RedirectToAction("Index", "Writer");
			}
			else
			{
				return View();

			}


		}
	}
}

//44-47 aras
//public IActionResult Index(Writer p)
//{
//	Context db = new Context(); //bağlantı

//	var valgiris = db.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);  // sart dogru ıse
//	if (valgiris != null)  // bos değilse
//	{
//		HttpContext.Session.SetString("UserName", p.WriterMail);  // key,value dogru ise
//		return RedirectToAction("Index", "Writer");

//	}
//	else
//	{
//		return View();
//	}

//}