using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace exe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            Random aleatorio = new Random();

            for (int i = 0; i < 20; i++)
            {
                numeros.Add(aleatorio.Next(1, 1000));
            }

            Console.WriteLine("-------Listar todos os numeros---------");
            foreach (int num in numeros)
            {
                Console.Write($"{num} ");
            }


            Console.WriteLine("\n\n-------Listar os numeros > 250 ---------");
            foreach (int num in numeros.Where(x => x > 250))
            {
                Console.Write($"{num} ");
            }


            Console.WriteLine("\n\n-------Listar os numeros pares ---------");
            foreach (int num in numeros.Where(x => x % 2 == 0))
            {
                Console.Write($"{num} ");
            }


            Console.WriteLine("\n\n-------Listar os numeros impares ---------");
            foreach (int num in numeros.Where(x => x % 2 != 0))
            {
                Console.Write($"{num} ");
            }


            Console.WriteLine("\n\n-------Listar todos os numeros ASC---------");
            foreach (int num in numeros.OrderBy(x => x))
            {
                Console.Write($"{num} ");
            }


            Console.WriteLine("\n\n-------Listar todos os numeros DESC---------");
            foreach (int num in numeros.OrderByDescending(x => x))
            {
                Console.Write($"{num} ");
            }


            int maior = numeros.Max();
            Console.WriteLine($"\n\nO maior é {maior}");

            int menor = numeros.Min();
            Console.WriteLine($"\n\nO menor é {menor}");

            double media = numeros.Average();
            Console.WriteLine($"\n\nA média é {media}");

            int soma = numeros.Sum();
            Console.WriteLine($"\n\nA soma é {soma}");


            Console.ReadKey();
        }
    }
}
