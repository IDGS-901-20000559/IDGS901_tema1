using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Services
{
    public class LeerServices
    {
        public Array LeerArchivo()
        {
            Array maestrosData = null;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/Datos.txt");

            if(File.Exists(archivo))
            {
                maestrosData = File.ReadAllLines(archivo);
            }

            return maestrosData;
        }
    }
}