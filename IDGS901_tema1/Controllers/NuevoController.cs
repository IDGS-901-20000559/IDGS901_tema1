using IDGS901_tema1.Models;
using IDGS901_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OperasBas(string n1, string n2, string grupo_opciones)
        {
            int res = 0;
            if (grupo_opciones == "opcion1")
            {
                res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            }
            else if(grupo_opciones == "opcion2")
            {
                res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
            }
            else if (grupo_opciones == "opcion3")
            {
                res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
            }
            else if (grupo_opciones == "opcion4")
            {
                res = Convert.ToInt16(n1) / Convert.ToInt16(n2);
            }

            ViewBag.Res = res;
            return View();
        }
        
        public ActionResult MuestraPulques()
        {
            var PulqueServices1 = new PulquesServices();
            var model=PulqueServices1.ObtenerPulque();

            return View(model);
        }

        public ActionResult Calculos(OperasBas op, string grupo_opciones)
        {
            op.tipoOperacion(grupo_opciones);

            return View(op);
        }
    }
}