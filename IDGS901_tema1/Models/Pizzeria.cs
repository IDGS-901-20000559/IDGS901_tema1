using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Models
{
    public class Pizzeria
    {
        public string NombreCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string TamanioPizza { get; set; }
        public string IngredientesPizza { get; set; }
        public int NumPizzas { get; set; }
        public double Subtotal { get; set; }
    }
}