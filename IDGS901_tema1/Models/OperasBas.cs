using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Models
{
    public class OperasBas
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public int Res { get; set; }

        public void tipoOperacion(String grupo_opciones)
        {
            if (grupo_opciones == "opcion1")
            {
                Suma();
            }
            else if (grupo_opciones == "opcion2")
            {
                Resta();
            }
            else if (grupo_opciones == "opcion3")
            {
               Multiplicacion();
            }
            else if (grupo_opciones == "opcion4")
            {
                Division();
            }
        }

        public void Suma()
        {
            this.Res = this.Num1+this.Num2;
        }
        public void Resta()
        {
            this.Res = this.Num1 - this.Num2;
        }
        public void Multiplicacion()
        {
            this.Res = this.Num1 * this.Num2;
        }
        public void Division()
        {
            this.Res = this.Num1 / this.Num2;
        }
    }
}