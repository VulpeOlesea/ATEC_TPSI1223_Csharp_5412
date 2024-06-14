using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo pasta = new DirectoryInfo(@"C:\ficheiros"); // путь к папке с файлами

            FileInfo[] ficheiros = pasta.GetFiles("*.pdf"); // выбрать определенный вид файлов, находящиеся в папке

            foreach (FileInfo fich in ficheiros) 
            {
                Console.Write($"\n{fich.Name} - {fich.CreationTime} - {fich.Length}Kb"); // вывод в терминале: имя/дата/размер
            }

            Console.ReadKey();
        }
    }
}
