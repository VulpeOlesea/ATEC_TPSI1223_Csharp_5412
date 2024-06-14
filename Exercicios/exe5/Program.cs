using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random(); // выводит рандомное число в терминал

            Console.WriteLine(aleatorio.Next(1, 100)); // в скобрах можно указать пределы поиска

            Console.ReadKey();
        }
    }
}
