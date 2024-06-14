using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo fich = new FileInfo(@"C:\ficheiros\ficheiro.txt"); // создаёт новый файл в определенной папке
            // StreamWriter escrever = fich.CreateText(); // создает текст внутри файла
            StreamWriter escrever = fich.AppendText(); // добавляет текст к существующему в файле
            escrever.WriteLine("Esta é a minha primeira linha"); // текст на одной строчке + переход на другую строку
            escrever.WriteLine("Esta e a minha segunda linha");
            escrever.WriteLine("Esta é a minha terceira linha");
            escrever.Write("Escrevi e não mudei de linha"); // текст на одной строке без перехода на другую строку
            escrever.Write("Fiquei na mesma linha");

            escrever.Close(); // перестаёт заполнять файл
        }
    }
}
