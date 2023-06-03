using IDGS901_tema1.Models;
using IDGS901_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class TrianguloController : Controller
    {
        public ActionResult Calculos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculos(Triangulo tr)
        {
            TrianguloServices services = new TrianguloServices();

            ViewBag.resultado = services.ObtenerResultado(tr);

            return View();
        }
    }
}