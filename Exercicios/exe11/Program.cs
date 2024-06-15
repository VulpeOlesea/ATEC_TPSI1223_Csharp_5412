using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exe11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<formando> turma = new List<formando>();

            formando f1 = new formando();
            f1.Nome = "Ana Pereira";
            f1.Morada = "Rua A";
            f1.Idade = 46;
            turma.Add(f1);

            formando f2 = new formando();
            f2.Nome = "Diogo Pereiro";
            f2.Morada = "Rua B";
            f2.Idade = 19;
            turma.Add(f2);

            formando f3 = new formando();
            f3.Nome = "Bia Pera";
            f3.Morada = "Rua C";
            f3.Idade = 23;
            turma.Add(f3);

            formando f4 = new formando();
            f4.Nome = "Isabela Mendes";
            f4.Morada = "Rua D";
            f4.Idade = 36;
            turma.Add(f4);

            formando f5 = new formando();
            f5.add_formando("Zacaria Lopes", "Rua E", 34);
            turma.Add(f5);

            foreach (formando f in turma)
            {
                Console.WriteLine($"{ f.Nome} - {f.Morada} - {f.Idade}");
            }

            Console.ReadKey();
        }

    }

    class formando
    {
        public void add_formando(string f_nome, string f_morada, int f_idade)
        {
            Nome = f_nome;
            Morada = f_morada;
            Idade = f_idade;
        }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public int Idade { get; set; }
    }
}
