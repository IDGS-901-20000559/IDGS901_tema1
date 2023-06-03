using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Services
{
    public class TraductorServices
    {
        public void GuardarPalabra(Traduccion trad)
        {
            var esp = trad.PalabraEspaniol.ToUpper();
            var ing = trad.PalabraIngles.ToUpper();

            var datos = esp + "-" + ing + "-" + Environment.NewLine;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/traduccion.txt");
            //(ubicacion, contenido)
            File.AppendAllText(archivo, datos);
        }

        public Array LeerPalabras()
        {
            Array palabras = null;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/traduccion.txt");

            if (File.Exists(archivo))
            {
                palabras = File.ReadAllLines(archivo);
            }

            return palabras;
        }

        public string BuscarPalabra(string palabra, string leng)
        {
            var palabraEncontrada = "";
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/traduccion.txt");

            if (File.Exists(archivo))
            {
                var lineas = File.ReadAllLines(archivo);
                bool encontrada = false;

                foreach (var linea in lineas)
                {
                    var palabras = linea.Split('-');

                    for (int i = 0; i < palabras.Length; i++)
                    {
                        if (palabras[i].Trim() == palabra)
                        {
                            encontrada = true;
                            if (leng == "esp")
                            {
                                palabraEncontrada = "LA TRADUCCION DE " + palabra + " ES " + palabras[i - 1].Trim();
                            }
                            else if (leng == "ing")
                            {
                                palabraEncontrada = "LA TRADUCCION DE " + palabra + " ES " + palabras[i + 1].Trim();
                            }
                        }
                    }
                }
                if (!encontrada)
                {
                    palabraEncontrada = "NO EXISTE ESA PALABRA EN EL DICCIONARIO";
                }
            }

            return palabraEncontrada;
        }
    }
    }