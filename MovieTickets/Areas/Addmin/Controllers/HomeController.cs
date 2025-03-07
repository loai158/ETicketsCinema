using Microsoft.AspNetCore.Mvc;

namespace MovieTickets.Areas.Addmin.Controllers
{
    [Area("Addmin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
