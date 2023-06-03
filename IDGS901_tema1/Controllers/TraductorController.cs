using IDGS901_tema1.Models;
using IDGS901_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace IDGS901_tema1.Controllers
{
    public class TraductorController : Controller
    {
        // GET: Traductor

        public ActionResult RegistrarPalabra() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarPalabra(Traduccion trad)
        {
            var op = new TraductorServices();
            op.GuardarPalabra(trad);

            return View();
        }

        public ActionResult RegistrarPalabraTabla()
        {
            var arch = new TraductorServices();
            ViewBag.Archivos = arch.LeerPalabras();
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarPalabraTabla(Traduccion trad)
        {
            var op = new TraductorServices();
            op.GuardarPalabra(trad);

            ViewBag.Archivos = op.LeerPalabras();
            return View();
        }

        public ActionResult BuscarPalabra()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BuscarPalabra(Traduccion trad)
        {
            var op = new TraductorServices();
            string palabra = trad.Busqueda.ToUpper();
            string lenguaje = trad.Activo;

            if(palabra != null && palabra != "" 
               && lenguaje != null && lenguaje != ""){
                ViewBag.resultado = op.BuscarPalabra(palabra, lenguaje);
                if (ViewBag.resultado == "NO EXISTE ESA PALABRA EN EL DICCIONARIO")
                {
                    ViewBag.text = "danger";
                }
                else
                {
                    ViewBag.text = "primary";
                }
            }
            else{
                ViewBag.resultado = "INGRESA TEXTO Y SELECCIONA EL IDIOMA PARA INICIAR LA BUSQUEDA";
                ViewBag.text = "info";
            }
            

            return View();
        }
    }
}