using Microsoft.AspNetCore.Mvc;
namespace AspNetCoreMiddleware.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Anasayfa()
        {
            return View();
        }

        public IActionResult Iletisim()
        {
            return View();
        }
    }
}
