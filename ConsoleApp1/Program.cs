using ConsoleApp1.api;
using ConsoleApp1.api.modelos;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        TestApi.Run();
        Thread.Sleep(10000);
    }

    public void Test()
    {
        // Primitivos
        int numero = 222222222;
        long numeroGrande = 2222222222222222222;
        bool variableBoleano = false;
        double numeroConDecimal = 3.4;
        float numeroFlotante = 0.0f;
        decimal numDecimal = 0.0m;
        char caracter = 'a';

        // Object
        String nombre = "";

        // Estructuras de datos
        int[] miArreglo = new int[2];
        miArreglo[0] = 4;
        miArreglo[1] = 5;

        List<String> miLista2 = new()
        {
            "Carmelita",
            "Magda",
            "Juan"
        };
        List<String> miLista = new List<string>();
        miLista.Add("Carmelita");
        miLista.Add("Magda");

        Dictionary<String, int> diccionario = new Dictionary<String, int>();
        diccionario.Add("Carmelita", 29);
        diccionario.Add("Magda", 30);

        var a = diccionario["Magda"];
        
        int b;
        diccionario.TryGetValue("Magda2", out b);

        Dictionary<String, int> diccionario2 = new()
        {
            { "Magda", 5 },
            { "Carmela", 6 }
        };


        Console.WriteLine("Hello, World!");
    }
}