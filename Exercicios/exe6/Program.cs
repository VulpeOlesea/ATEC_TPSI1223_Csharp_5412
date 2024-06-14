using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace exe6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo fich = new FileInfo(@"c:\ficheiros\euromilhoes.txt");
            StreamWriter escrever = fich.CreateText();

            Random aleatorio = new Random();
            escrever.Write("Numeros: ");

            for (int i = 1; i <= 5; i++)
            {
                escrever.Write(aleatorio.Next(1, 50) + " ");
            }

            escrever.Write("\n\nEstrelas: ");

            for (int i = 1; i <= 2; i++)
            {
                escrever.Write(aleatorio.Next(1, 12) + " ");
            }

            escrever.Close();
        }
    }
}
