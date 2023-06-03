using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class TemperaturaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult convertir(Temperatura temp) 
        {

            temp.Convertir();
            return View(temp);
        }
    }
}
