using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo novo = new FileInfo(@"C:\ficheiros\meuficheiro.txt"); // путь к папке в которой будет новый файл + название
            FileStream fstr = novo.Create(); // создает новый файл
            fstr.Close();
        }
    }
}
