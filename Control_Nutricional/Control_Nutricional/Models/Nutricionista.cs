using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Control_Nutricional.Models
{
    public class Nutricionista
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Residencia { get; set; }
    }
}