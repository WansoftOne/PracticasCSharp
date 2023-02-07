using ConsoleApp1.objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.utils
{
    public class Utils
    {
        // Cualquier otra clase puede acceder a esta propiedad.
        public int campoPublico;
        // Solo la clase Utils y clases que extienden la clase Utils puede acceder a esta propiedad.
        protected int campoProtegido;
        // Solo la clase Utils puede acceder a esta propiedad.
        private int campoPrivado;

        // Constructor
        public Utils()
        {

        }

        public void Test()
        {
            MariaLuisa mariaLuisa = new MariaLuisa();
            mariaLuisa.precio = 54;
            mariaLuisa.Test();
            mariaLuisa.DoSomething();

            Console.WriteLine("Ejecutando Test en clase Utils");
        }
    }
}
