using Microsoft.AspNetCore.Mvc;
using Practica1.Models;
using System.Diagnostics;

namespace Practica1.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //Sin una acción no hay vista
        public IActionResult Ejercicio(double number1, double number2)
        {
            if (number1>10 || number2 > 10)
            {
                return View("NoMayores");
            }
            Double result = number1 + number2;
            ViewBag.Numbers1 = number1;
            ViewBag.Numbers2 = number2;
            ViewBag.VariableAEnviar=result;
            return View();
        }

        public IActionResult NoMayores()
        {
            return View();
        }

        public IActionResult Multi(double number1, double number2)
        {
            if (number1 > 10 || number2 > 10)
            {
                return View("NoMayores");
            }
            Double result = number1 * number2;
            ViewBag.Numbers1 = number1;
            ViewBag.Numbers2 = number2;
            ViewBag.VariableAEnviar = result;
            return View();

        }
        
        public IActionResult Resta(double number1, double number2)
        {
            if (number1 > 10 || number2 > 10)
            {
                return View("NoMayores");
            }
            Double result = number1 - number2;
            ViewBag.Numbers1 = number1;
            ViewBag.Numbers2 = number2;
            ViewBag.VariableAEnviar = result;
            return View();
        }

        public IActionResult Div(double number1, double number2)
        {
            if (number1 > 10 || number2 > 10)
            {
                return View("NoMayores");
            }
            Double result = number1 / number2;
            ViewBag.Numbers1 = number1;
            ViewBag.Numbers2 = number2;
            ViewBag.VariableAEnviar = result;
            return View();
        }
    }
}