﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HolaMundoCore.Models;
using HolaMundoCore.Services;

namespace HolaMundoCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            /*PaisRepositorioEnMemoria paisRepo = new PaisRepositorioEnMemoria();

            paisRepo.obtenerTodos();*/

            return View();
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
