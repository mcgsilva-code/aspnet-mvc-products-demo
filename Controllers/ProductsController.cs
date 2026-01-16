using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
