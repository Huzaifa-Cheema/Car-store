using Microsoft.AspNetCore.Mvc;

namespace Car_rental_system.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
