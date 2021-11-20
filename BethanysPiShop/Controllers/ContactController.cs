using Microsoft.AspNetCore.Mvc;

namespace BethanysPiShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
