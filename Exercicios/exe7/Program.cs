using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exe7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader leitor = File.OpenText(@"C:\ficheiros\ficheiro.txt"); // прочитать содержимое файла

            string linha = null; // читает каждую линию в файле

            while ((linha = leitor.ReadLine()) != null) // читает до тех пор пока линия не будет пустой
            {
                Console.WriteLine(linha);
            }

            leitor.Close();

            Console.ReadKey();
        }
    }
}
