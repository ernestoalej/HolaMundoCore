using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HolaMundoCore.Models;

namespace HolaMundoCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Pais> pais = new List<Pais>()
            {
                new Pais
                {
                    Id = 1,
                    Nombre= "Venezuela"
                },

                new Pais
                {
                    Id = 2,
                    Nombre= "Colombia"
                },

                new Pais
                {
                    Id = 3,
                    Nombre= "Mexico"
                },
            };
            

            return View(pais);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
