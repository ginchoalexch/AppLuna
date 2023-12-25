using AppLuna.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppLuna.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TeBajoLaLunaJson(string name)
        {
            string nombre = "", url = "";
            string nombreLetra = name.Substring(0,1).ToUpper();
            string nombreDemas = name.Substring(1).ToLower().Trim();
            nombre = nombreLetra + nombreDemas;
            url = "/Home/TeBajoLaLuna";

            return Ok(new { name = nombre, url = url });
        }
        public IActionResult TeBajoLaLuna(string name)
        {
            if (name.ToUpper().Trim() == "LOURDES" || name.ToUpper().Trim() == "GEANETH")
            {
                string nombreLetra = name.Substring(0, 1).ToUpper();
                string nombreDemas = name.Substring(1).ToLower().Trim();
                ViewBag.Name = nombreLetra + nombreDemas;
                return View();
            }
            else { return Redirect("/Error"); }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
