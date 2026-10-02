using FarmaciaNuevaVida.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FarmaciaNuevaVida.Controllers
{
    public class ProductosController : Controller
    {
        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Producto producto)
        {
            if (!ModelState.IsValid)
            {
                return View(producto);
            }

            return View("Confirmacion", producto);
        }
    }
}
