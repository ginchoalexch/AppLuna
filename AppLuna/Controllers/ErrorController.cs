using Microsoft.AspNetCore.Mvc;

namespace AppLuna.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
