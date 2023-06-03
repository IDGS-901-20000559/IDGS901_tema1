using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Services
{
    public class TrianguloServices
    {
        public void CalcularDistancia(Triangulo t)
        {
            t.lado1 = Math.Sqrt(Math.Pow(t.a2 - t.a1, 2) + Math.Pow(t.b2 - t.b1, 2));
            t.lado2 = Math.Sqrt(Math.Pow(t.a3 - t.a2, 2) + Math.Pow(t.b3 - t.b2, 2));
            t.lado3 = Math.Sqrt(Math.Pow(t.a1 - t.a3, 2) + Math.Pow(t.b1 - t.b3, 2));
        }

        public string ObtenerResultado(Triangulo t)
        {
            CalcularDistancia(t);
            string resultado = "";

            // La suma de dos lados siempre debe ser mayor que el tercer lado para ser un triángulo
            if (t.lado1 + t.lado2 > t.lado3 
                && t.lado1 + t.lado3 > t.lado2 
                && t.lado2 + t.lado3 > t.lado1)
            {
                string tipoTriangulo = "";
                double area = 0;

                if (Math.Round(t.lado1) == Math.Round(t.lado2) && Math.Round(t.lado1) == Math.Round(t.lado3) && Math.Round(t.lado2) == Math.Round(t.lado3))
                {
                    tipoTriangulo = "equilátero";
                }
                else if (Math.Round(t.lado1, 2) == Math.Round(t.lado2) || Math.Round(t.lado1) == Math.Round(t.lado3) || Math.Round(t.lado2) == Math.Round(t.lado3))
                {
                    tipoTriangulo = "isósceles";
                }
                else
                {
                    tipoTriangulo = "escaleno";
                }

                double semPer = (t.lado1 + t.lado2 + t.lado3) / 2;

                area = Math.Sqrt(semPer * (semPer - t.lado1) * (semPer - t.lado2) * (semPer - t.lado3));

                resultado = "Las coordenadas forman un triángulo " + tipoTriangulo + ". Su área es de " + area + " u²";
            }
            else
            {
                resultado = "LAS COORDENADAS NO FORMAN UN TRIÁNGULO";
            }
            return resultado;
        }
    }

}