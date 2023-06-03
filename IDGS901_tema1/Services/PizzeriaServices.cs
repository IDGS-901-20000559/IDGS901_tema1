using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Services
{
    public class PizzeriaServices
    {
        public void AgregarPedido(Pizzeria p)
        {
            var precio = 0;

            if(p.TamanioPizza == "Chica")
            {
                precio = 40;
            }else if (p.TamanioPizza  == "Mediana")
            {
                precio = 80;
            }else if(p.TamanioPizza == "Grande")
            {
                precio = 120;
            }

            p.Subtotal = (10 + precio) * p.NumPizzas;

            var datos = p.NombreCliente + "-" + p.DireccionCliente + "-" 
                      + p.TelefonoCliente + "-" + p.TamanioPizza + "-" 
                      + p.IngredientesPizza + "-" + p.NumPizzas + "-" + 
                      p.Subtotal+ Environment.NewLine;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/pizzeria.txt");
            //(ubicacion, contenido)
            File.AppendAllText(archivo, datos);
        }

        public Array VerPedidos()
        {
            Array pedidos = null;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/pizzeria.txt");

            if (File.Exists(archivo))
            {
                pedidos = File.ReadAllLines(archivo);
            }

            return pedidos;
        }

        public Array VerPedido(Pizzeria p)
        {
            Array pedidosEncontrados = null;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/pizzeria.txt");

            if (File.Exists(archivo))
            {
                var pedidos = File.ReadAllLines(archivo);

                foreach (var pedido in pedidos)
                {
                    var pedidosF = pedido.Split('-');

                    for (int i = 0; i < pedidosF.Length; i++)
                    {
                        if (pedidosF[i].Trim() == p.NombreCliente)
                        {
                            pedidosEncontrados.SetValue(pedido, 0);
                        }
                    }
                }
            }

            return pedidosEncontrados;
        }
    }
}