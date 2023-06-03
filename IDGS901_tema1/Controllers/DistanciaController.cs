using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class DistanciaController : Controller
    {
        public ActionResult CalcularDistancia()
        {
            return View();
        }

        public ActionResult MostrarResultado(Distancia ds)
        {
            ds.calculos();
            return View(ds);
        }
    }
}
