using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LaPiranaPractice.Models;

namespace LaPiranaPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
//--------------------------------PRESENTACION DE LA EMPRESA---------------------------
        //Página: QUIENES SOMOS
        public IActionResult Index()
        {
            return View();
        }

        //Página: Servicios y Productos
        public IActionResult Servicios()
        {
            return View();
        }
        
        //Página: FORMULARIO Contacto
        public IActionResult Contacto()
        {
            return View();
        }

        //Página: Recibe datos de FORMULARIO Contacto
        [HttpPost]
        public IActionResult Contacto(String datos)
        {
            return View();
        }

        //Página: Confirmación de recepcion de datos de FORMULARIO Contacto
        public IActionResult ContactoConfirmacion()
        {
            return View();
        }
//----------------------------------PRODUCTOS Y SERVICIOS-------------------------------
    }
}


