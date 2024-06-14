using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exe8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo fich = new FileInfo(@"C:\ficheiros\original.txt");
            StreamWriter escrever = fich.CreateText();
            escrever.WriteLine("Ola Mundo!");

            escrever.Close();

            StreamReader leitor = File.OpenText(@"C:\ficheiros\original.txt");
            FileInfo fich2 = new FileInfo(@"C:\ficheiros\copiaoriginal.txt");
            StreamWriter escrever2 = fich2.CreateText();

            string linha = null;

            while ((linha = leitor.ReadLine()) != null)
            {
                escrever2.WriteLine(linha);
            }

            leitor.Close();
            escrever2.Close();

            Console.ReadKey();
        }
    }
}
