using Microsoft.AspNetCore.Mvc;

namespace FarmaciaNuevaVida.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
