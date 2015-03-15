using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Control_Nutricional.Models
{
    public class Paciente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }
        public int Telefono { get; set; }
        
    }
}