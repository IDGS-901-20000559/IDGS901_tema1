using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class EscuelaController : Controller
    {
        public ViewResult Index()
        {
            //return Content("<h1> IDGS901-DWI </h1>");
            TempData["Nombre"] = "Jonathan Estuvo Aqui";
            return View();
        }

        public JsonResult About()
        {
          var pulque = new Pulques() 
          { 
            Producto = "Pulque",
            Descripcion = "Mango",
            litros = 20,
            Produccion = new DateTime(2023, 12, 4)
          };
          
           return Json(pulque, JsonRequestBehavior.AllowGet);
           //return View();
        }

        public RedirectResult About1() 
        {
            return Redirect("https://www.google.com");
        }

        public RedirectToRouteResult About2()
        {
            TempData["Nombre"] = "Jonathan Estuvo Aqui";
            return RedirectToAction("Informacion");
        }

        public ActionResult Informacion()
        {
            ViewBag.Grupo = "IDGS901";
            ViewData["Materia"] = "DWI";

            String nombre = "";

            if (TempData.ContainsKey("Nombre"))
            {
                nombre = TempData["Nombre"]as string;
            }

            ViewBag.Nombre = nombre;

            return View();
        }

        
    }
}
