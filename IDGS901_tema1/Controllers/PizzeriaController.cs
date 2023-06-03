using IDGS901_tema1.Models;
using IDGS901_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class PizzeriaController : Controller
    {
        // GET: Pizzeria
        public ActionResult Index()
        {
            PizzeriaServices piServ = new PizzeriaServices();
            ViewBag.pedidos = piServ.VerPedidos();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Pizzeria p)
        {
            PizzeriaServices piServ = new PizzeriaServices();

            piServ.AgregarPedido(p);

            ViewBag.pedidos = piServ.VerPedidos();

            return View();
        }
    }
}