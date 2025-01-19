using Microsoft.AspNetCore.Mvc;

namespace MyApiNight4.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
