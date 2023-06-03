using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Models
{
    public class Temperatura
    {
        public double temperatura { get; set; }
        public double gradosCelsius { get; set; }
        public double gradosFarenheit { get; set;}
        
        public String result { get; set; }
        public int Activo { get; set;}

        public void Convertir() {
            if(this.Activo == 1)
            {
                this.gradosCelsius =  (this.temperatura - 32) / 1.8;
                this.result = gradosCelsius+"°C";
            }
            else if(this.Activo == 2)
            {
                this.gradosFarenheit = this.temperatura * 1.8 + 32;
                this.result = gradosFarenheit+"°F";
            }
        }
    }
}