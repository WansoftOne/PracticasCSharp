using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.objetos
{
    internal class MariaLuisa: Producto
    {
        public char tipo;
    
        public void Test()
        {
            Console.WriteLine(precio);
            DoSomething();
        }

        public void DoSomething()
        {
            Console.WriteLine("DoSomething");
        }
    }
}
