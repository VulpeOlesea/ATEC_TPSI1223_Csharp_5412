using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace exe14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            List<Software> lst_soft = new List<Software>();
            StreamReader ler = new StreamReader(@"C:\ficheiros\software.txt", Encoding.GetEncoding("iso-8859-1"));

            string linha;
            char[] limitadores = { '&', '&', '&' };
            while ((linha = ler.ReadLine()) != null)
            {
                Software sf = new Software();
                
                string[] expressoes = linha.Split(limitadores);

                if (expressoes.Length >= 4 )
                {
                    sf.add_soft(expressoes[0], expressoes[1], int.Parse(expressoes[2]), int.Parse(expressoes[3]));
                    lst_soft.Add(sf);
                }
            }
            ler.Close();

            do
            {
                Console.Clear();
                Console.WriteLine("1 – Mostrar no ecran o conteúdo de todo o ficheiro");
                Console.WriteLine("2 – Mostrar no ecran apenas os softwares da “Microsoft”");
                Console.WriteLine("3 – Mostrar no ecran apenas os softwares com quantidade superior a 25");
                Console.WriteLine("4 – Perguntar ao utilizador qual o ano de aquisição mostrar só os produtos desse ano");
                Console.WriteLine("5 – Mostrar no ecran o total da soma de todas as quantidades");
                Console.WriteLine("6 – Mostrar no ecran todos os softwares, ordenando de forma descendente pela quantidade");
                Console.WriteLine("7 – Gerar um ficheiro “Symantec.txt” que deverá conter todos os softwares da “Symantec”");
                Console.WriteLine("8 – Mostrar no ecran todos os produtos adquiridos há mais de 5 anos(calcular em função da data do sistema)");
                Console.WriteLine("9 – Sair");

                Console.WriteLine("Qual a opção que pretende?");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: //1 – Mostrar no ecran o conteúdo de todo o ficheiro
                        foreach (Software sf in lst_soft)
                        {
                            Console.WriteLine($"{sf.Soft} - {sf.Empresa} - {sf.Ano} - {sf.Quantidade}");
                        }
                        Console.ReadKey();
                        break;

                    case 2: //2 – Mostrar no ecran apenas os softwares da “Microsoft”
                        foreach (Software sf in lst_soft.Where(x => x.Empresa.Contains("Microsoft")))
                        {
                            Console.WriteLine($"{sf.Soft} - {sf.Empresa} - {sf.Ano} - {sf.Quantidade}");
                        }
                        Console.ReadKey();
                        break;

                    case 3: //3 – Mostrar no ecran apenas os softwares com quantidade superior a 25
                        foreach (Software sf in lst_soft.Where(x => x.Quantidade > 25))
                        {
                            Console.WriteLine($"{sf.Soft} - {sf.Empresa} - {sf.Ano} - {sf.Quantidade}");
                        }
                        Console.ReadKey();
                        break;

                    case 4: //4 – Perguntar ao utilizador qual o ano de aquisição mostrar só os produtos desse ano
                        Console.WriteLine("Escreva qual o ano de aquisição mostrar: ");
                        string getAno = Console.ReadLine();

                        if (int.TryParse(getAno, out int ano))
                        {
                            foreach (Software sf in lst_soft.Where(x => x.Ano == ano))
                            {
                                Console.WriteLine($"{sf.Soft} - {sf.Empresa} - {sf.Ano} - {sf.Quantidade}");
                            }
                        }
                        Console.ReadKey();
                        break;

                    case 5: //5 - Mostrar no ecran o total da soma de todas as quantidades
                        int soma = lst_soft.Sum(x => x.Quantidade);
                        Console.WriteLine($"A soma total de todas as quantidades é {soma}.");
                        Console.ReadKey();
                        break;

                    case 6: //6 – Mostrar no ecran todos os softwares, ordenando de forma descendente pela quantidade
                        foreach (Software sf in lst_soft.OrderByDescending(x => x.Quantidade))
                        {
                            Console.WriteLine($"{sf.Soft} - {sf.Empresa} - {sf.Ano} - {sf.Quantidade}");
                        }
                        Console.ReadKey();
                        break;

                    case 7: //7 – Gerar um ficheiro “Symantec.txt” que deverá conter todos os softwares da “Symantec”"
                        FileInfo fich = new FileInfo(@"C:\ficheiros\Symantec.txt");
                        StreamWriter escrever = fich.CreateText();

                        foreach (Software sf in lst_soft.Where(x => x.Empresa.Contains("Symantec")))
                        {
                            escrever.WriteLine($"{sf.Soft} - {sf.Empresa} - {sf.Ano} - {sf.Quantidade}");
                        }
                        escrever.Close();
                        Console.WriteLine("Ficheiro gerado com sucesso.");
                        Console.ReadKey();
                        break;

                    case 8: // 8 – Mostrar no ecran todos os produtos adquiridos há mais de 5 anos(calcular em função da data do sistema)
                        int ano_atual = DateTime.Now.Year;
                        foreach (Software sf in lst_soft.Where(x => ano_atual - x.Ano > 5))
                        {
                            Console.WriteLine($"{sf.Soft} - {sf.Empresa} - {sf.Ano} - {sf.Quantidade}");
                        }
                        Console.ReadKey();
                        break;

                    case 9:
                        break;

                    default:
                        Console.WriteLine("Erro. Esta opção não existe.");
                        Console.WriteLine("Escolha uma opção de 1 a 9.");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 9);

            Console.ReadKey();
        }
    }
        class Software
        {
            public void add_soft(string f_soft, string f_empresa, int f_ano, int f_quant)
            {
                Soft = f_soft;
                Empresa = f_empresa;
                Ano = f_ano;
                Quantidade = f_quant;
            }
            public string Soft { get; set; }
            public string Empresa { get; set; }
            public int Ano { get; set; }
            public int Quantidade { get; set; }
        }
    }
