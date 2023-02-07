using ConsoleApp1.api.modelos;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.api
{
    internal class TestApi
    {
        public static async Task Run()
        {
            //
            IAnimalitosApi api = RestService.For<IAnimalitosApi>("http://192.168.100.8:4000");

            Animalito animalito = new Animalito();
            animalito.Nombre = "Pancho";
            animalito.EdadMascota = 3;
            animalito.NombreDuenio = "Carlitos";
            animalito.Tipo = "Gato";
            animalito.Diagnostico = "Pedos";


            Respuesta r = await api.RegistrarAnimalito(animalito);
            Console.WriteLine(r.Mensaje);
            List<Animalito> animalitos = await api.GetAnimalitos();
            for (int i = 0; i < animalitos.Count; i++)
            {
                Console.WriteLine(animalitos[i].ToString());
            }

            Animalito a = await api.GetAnimalito(2);
            Console.WriteLine(a.Nombre);
        }
    }
}
