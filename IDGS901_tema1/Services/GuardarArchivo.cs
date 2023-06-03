using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Services
{
    public class GuardarServices
    {
        public void GuardarArchivo(Maestros maestro){
            var mat = maestro.Matricula;
            var nom = maestro.Nombre;
            var apa = maestro.Apaterno;
            var ama = maestro.Amaterno;
            var email = maestro.Email;
            var datos = mat+", "+nom+", "+apa+", "+ama+","+email + "," + Environment.NewLine;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/Datos.txt");

                           //(ubicacion, contenido)
            File.AppendAllText(archivo  , datos);
            //File.WriteAllText(archivo , datos );
        }
    }
}