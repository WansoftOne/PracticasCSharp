using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.api.modelos
{
    internal class Animalito
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int EdadMascota { get; set; }
        public string NombreDuenio { get; set; }
        public string Tipo { get; set; }
        public string Diagnostico { get; set; }

        public string ToString()
        {
            return "Nombre: " + Nombre;
        }
    }
}
