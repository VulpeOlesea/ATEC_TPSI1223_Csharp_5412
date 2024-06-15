using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.SqlServer.Server;
using System.IO.Ports;

namespace exe12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao=0;
            List<Backup> lst_backups = new List<Backup>();
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Carregar ficheiro “backups.txt”");
                Console.WriteLine("2 - Listar todos os backups(com e sem erro) existentes no ficheiro");
                Console.WriteLine("3 - Apresentar os n°s totais de backups “Prioritários” e “Normais” de forma separada");
                Console.WriteLine("4 - Listar backups com “Sucesso” do ano atual(calcular a partir da data de sistema)");
                Console.WriteLine("5 - Listar os backups com “Erro”");
                Console.WriteLine("6 - Sair");

                Console.WriteLine("Qual a opção que pretende?");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        StreamReader ler = new StreamReader(@"C:\ficheiros\backups.txt", Encoding.GetEncoding("utf-8"));

                        string linha;
                        while ((linha = ler.ReadLine()) != null)
                        {
                            Backup bak = new Backup();
                            string tipo = linha.Substring(0, 1);

                            string dataTexto = linha.Substring(1, 8);
                            DateTime data = DateTime.ParseExact(dataTexto, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

                            string msg = linha.Substring(10);

                            bak.add_backup(tipo, data, msg);
                            lst_backups.Add(bak);
                        }

                        break;

                    case 2:
                        foreach (Backup b in lst_backups)
                        {
                            Console.WriteLine($"{b.Tipo} - {b.Data} - {b.Mensagem}");
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        int numPrioritarios = lst_backups.Where(x => x.Tipo == "P").Count();
                        int numNormais = lst_backups.Where(x => x.Tipo == "N").Count();

                        Console.WriteLine($"Prioritários: {numPrioritarios}");
                        Console.WriteLine($"Normais: {numNormais}");
                        Console.ReadKey();
                        break;

                    case 4:
                        int ano_atual = DateTime.Now.Year;
                        foreach (Backup b in lst_backups.Where(x=>x.Data.Year == ano_atual && x.Mensagem.Contains("sucesso")))
                        {
                            Console.WriteLine($"{b.Tipo} - {b.Data} - {b.Mensagem}");
                        }
                        Console.ReadKey();
                        break;

                    case 5:
                        foreach (Backup b in lst_backups.Where(x=>x.Mensagem.Contains("Erro")))
                        {
                            Console.WriteLine($"{b.Tipo} - {b.Data} - {b.Mensagem}");
                        }
                        Console.ReadKey();
                        break;

                }
            } while (opcao != 6);

            Console.ReadKey();
        }
    }

    class Backup
    {
        public void add_backup(string f_tipo, DateTime f_data, string f_msg)
        {
            Tipo = f_tipo;
            Data = f_data;
            Mensagem = f_msg;
        }
        public string Tipo { get; set; }
        public DateTime Data { get; set; }
        public string Mensagem { get; set; }
    }
}
