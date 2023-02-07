using ConsoleApp1.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.objetos
{
    public class Persona: Utils
    {
        public void Test()
        {
            Utils u = new Utils();
            u.Test();
            int campoPublico = u.campoPublico;
            // No es posible acceder a propiedades privadas de la clase Utils
            //int campoPrivado = u.campoPrivado;

            // 
            int c = campoProtegido;
            //int p = campoPrivado;
        }
    }
}
