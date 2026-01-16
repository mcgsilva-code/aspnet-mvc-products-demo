using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApp.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
