using System;
using System.Collections.Generic;

namespace DesenhandoArvore
{
    class Program
    {
        static void Main(string[] args)
        {
            ListarMarcas();
        }

        public static void ListarMarcas()
        {
            var listaMarcas = new List<string>();
            listaMarcas.Add("Renault");
            listaMarcas.Add("Fiat");
            listaMarcas.Add("Citroen");
            listaMarcas.Add("Ferrari");
            listaMarcas.Add("BMW");
            listaMarcas.ForEach(i => Console.WriteLine(i));
        }

        public static void ListarCerveja()
        {
            var listaCerveja = new List<string>();
            listaCerveja.Add("Original");
            listaCerveja.Add("Skol");
            listaCerveja.Add("Budweiser");
            listaCerveja.Add("Brahma");
            listaCerveja.ForEach(i => Console.WriteLine(i));
        }

        public static void CalcularArea()
        {
            Console.Write("Digite a base do quadrado: ");
            var baseQuadr = Console.ReadLine();
            Console.Write("Digite a altura do quadrado: ");
            var alturaQuadr = Console.ReadLine();
            Console.WriteLine($"Área do quadrado: {Convert.ToInt32(baseQuadr) * Convert.ToInt32(alturaQuadr)}");
        }

        public static void ReturnTree()
        {
            var caracter = "/";
            var caracterCresce = $"\\";
            var tamanhoLenght = 10;
            var tamanhoEspacos = 10;
            for (int i = 0; i <= tamanhoLenght; i++)
            {
                for (int b = 0; b < tamanhoEspacos; b++)
                {
                    Console.Write(" ");
                }
                tamanhoEspacos--;
                Console.Write(caracter);
                for (int j = 0; j < i; j++)
                {
                    Console.Write("**");
                }
                Console.WriteLine($"{caracterCresce}");
            }
            for (int c = 0; c < 5; c++)
            {
                for (int i = 0; i < tamanhoLenght - 1; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("****");
            }
        }
    }
}
