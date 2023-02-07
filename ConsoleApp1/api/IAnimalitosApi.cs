using ConsoleApp1.api.modelos;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.api
{
    internal interface IAnimalitosApi
    {
        [Post("/AgregarAnimales")]
        public Task<Respuesta> RegistrarAnimalito([Body] Animalito animal);

        [Get("/animalitos/todos")]
        public Task<List<Animalito>> GetAnimalitos();

        [Get("/animalitosId/{id}")]
        public Task<Animalito> GetAnimalito(int id);
    }
}
