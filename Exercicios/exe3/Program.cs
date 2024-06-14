using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exe3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo apagar = new FileInfo(@"C:\ficheiros\meuficheiro.txt"); // путь к папке, в которой есть файл на удаление
            apagar.Delete(); // удаляет выбранный файл
        }
    }
}
