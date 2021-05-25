using Microsoft.AspNetCore.Mvc;

namespace LaPiranaPractice.Controllers
{
    public class VentasController : Controller
    {
        public IActionResult Servicios(){
            return View();
        }
        public IActionResult Productos(){
            return View();
        }
        public IActionResult ProductosDestacados(){
            return View();
        }
    }
}