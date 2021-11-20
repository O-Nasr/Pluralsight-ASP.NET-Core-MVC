using Microsoft.AspNetCore.Mvc;

namespace BethanysPiShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
