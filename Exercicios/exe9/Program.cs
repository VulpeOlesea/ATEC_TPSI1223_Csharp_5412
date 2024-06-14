using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exe9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cores = new List<string>();

            cores.Add("Amarelo");
            cores.Add("Vermelho");
            cores.Add("Azul");
            cores.Add("Verde");
            cores.Add("Castanho");
            cores.Add("Cinzento");
            cores.Add("Roxo");
            cores.Add("Laranja");
            cores.Add("Rosa");
            cores.Add("Preto");


            Console.WriteLine("-----------------Listar todas as cores------------------");

            foreach (string cor in cores)
            {
                Console.WriteLine(cor);
            }



            Console.WriteLine("\n\n-----------------Listar as cores que começam por C ------------------");

            foreach (string cor in cores.Where(x => x.Substring(0, 1) == "C"))
            {
                Console.WriteLine(cor);
            }



            Console.WriteLine("\n\n-----------------Listar todas as cores ordenadas ASC ------------------");

            foreach (string cor in cores.OrderByDescending(x => x))
            {
                Console.WriteLine(cor);
            }

            Console.ReadKey();
        }
    }
}
