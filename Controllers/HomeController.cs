using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jojo.Models;

namespace jojo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            ViewData["Message"] = "Your login page.";

            return View();
        }

         public IActionResult Menu_Bib()
        {
            ViewData["Message"] = "MENU PRINCIPAL - BIBLIOTECÓLOGO";

            return View();
        }

         public IActionResult Menu_Est()
        {
            ViewData["Message"] = "MENU PRINCIPAL - ESTUDIANTE";

            return View();
        }
        public IActionResult Prestamo()
        {
            ViewData["Message"] = "Your Prestamo page.";

            return View();
        }
       
        public IActionResult RegistrarLibro()
        {
            return View();
        }
        public IActionResult DetalleLib()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
