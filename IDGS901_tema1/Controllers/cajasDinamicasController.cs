using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class cajasDinamicasController : Controller
    {
        // GET: cajasDinamicas
        public ActionResult Index(int? numero)
        {
            if (numero != null)
            {
                ViewBag.Num = numero;
            }   

            return View();
        }

        public ActionResult calculos(int[] campo)
        {
            ViewBag.numeroMenor = campo.Min();
            ViewBag.numeroMayor = campo.Max();
            ViewBag.promedio = campo.Average();

            Dictionary<int, int> numerosRepetidos = EncontrarNumerosRepetidos(campo);
            String numRep = "";
            foreach (KeyValuePair<int, int> kvp in numerosRepetidos)
            {
                numRep+="El numero " + kvp.Key + " se repite en " + kvp.Value+ " ocasiones\n";
            }
            ViewBag.rep = numRep;

            return View(); 
        }

        public static Dictionary<int, int> EncontrarNumerosRepetidos(int[] numeros)
        {
            Dictionary<int, int> numerosRepetidos = new Dictionary<int, int>();

            foreach (int numero in numeros)
            {
                if (numerosRepetidos.ContainsKey(numero))
                {
                    numerosRepetidos[numero]++;
                }
                else
                {
                    numerosRepetidos[numero] = 1;
                }
            }

            return numerosRepetidos;
        }
    }
}
