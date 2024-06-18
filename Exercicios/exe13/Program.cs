using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.SqlServer.Server;

namespace exe13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            List<Auchan> lst_auchan = new List<Auchan>();
            StreamReader ler = new StreamReader(@"C:\ficheiros\auchan.txt", Encoding.GetEncoding("iso-8859-1"));

            string linha;
            char[] limitadores = { '*', '#', '|', '&' };
            while ((linha = ler.ReadLine()) != null)
            {
                Auchan a = new Auchan();
                /*int ind = linha.IndexOf("*");
                string prod = linha.Substring(0, ind);

                int ind2 = linha.IndexOf("#");
                int preco = int.Parse(linha.Substring(ind + 1, ind2 - ind - 1));

                int ind3 = linha.IndexOf("|");
                int quant = int.Parse(linha.Substring(ind2 + 1, ind3 - ind2 - 1));

                int ind4 = linha.IndexOf("&");
                string secao = linha.Substring(ind3 + 1, ind4 - ind3 - 1);

                string mercado = linha.Substring(ind4 + 1);*/

                string[] expressoes = linha.Split(limitadores);
                a.add_auchan(expressoes[0], int.Parse(expressoes[1]), int.Parse(expressoes[2]), expressoes[3], expressoes[4]);

                //a.add_auchan(prod, preco, quant, secao, mercado);
                lst_auchan.Add(a);
            }
            ler.Close();

            do
            {
                Console.Clear();
                Console.WriteLine("1 – Mostrar no ecran o conteúdo de todo o ficheiro");
                Console.WriteLine("2 – Mostrar no ecran apenas os produtos do Hipermercado de “Setúbal”");
                Console.WriteLine("3 – Mostrar no ecran apenas os produtos da seção “Charcutaria” ordenados por quantidade de forma descendente");
                Console.WriteLine("4 – Mostrar no ecran apenas os produtos do Hipermercado do “Porto” e que sejam da seção “Charcutaria”");
                Console.WriteLine("5 – Mostrar no ecran o total da soma de todos os preços finais");
                Console.WriteLine("6 – Gerar um ficheiro “Setubal.txt” que deverá conter todos os produtos do Hipermercado “Setúbal”");
                Console.WriteLine("7 – Gerar um ficheiro “Peixaria.txt” que deverá conter todos os produtos da seção “Peixaria”");
                Console.WriteLine("8 – Sair");

                Console.WriteLine("Qual a opção que pretende?");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: //1 – Mostrar no ecran o conteúdo de todo o ficheiro
                        foreach (Auchan a in lst_auchan)
                        {
                            Console.WriteLine($"{a.Produto} - {a.Preco} - {a.Quantidade} - {a.Secao} - {a.Hipermercado}");
                        }
                        Console.ReadKey();
                        break;

                    case 2: //2 – Mostrar no ecran apenas os produtos do Hipermercado de “Setúbal”
                        foreach (Auchan a in lst_auchan.Where(x => x.Hipermercado.Contains("Setúbal")))
                        {
                            Console.WriteLine($"{a.Produto} - {a.Preco} - {a.Quantidade} - {a.Secao} - {a.Hipermercado}");
                        }
                        Console.ReadKey();
                        break;

                    case 3: //3 – Mostrar no ecran apenas os produtos da seção “Charcutaria” ordenados por quantidade de forma descendente
                        foreach (Auchan a in lst_auchan.Where(x => x.Secao.Contains("Charcutaria")).OrderByDescending(x => x.Quantidade))
                        {
                            Console.WriteLine($"{a.Produto} - {a.Preco} - {a.Quantidade} - {a.Secao} - {a.Hipermercado}");
                        }
                        Console.ReadKey();
                        break;

                    case 4: //4 – Mostrar no ecran apenas os produtos do Hipermercado do “Porto” e que sejam da seção “Charcutaria”
                        foreach (Auchan a in lst_auchan.Where(x => x.Hipermercado.Contains("Porto") && x.Secao.Contains("Charcutaria")))
                        {
                            Console.WriteLine($"{a.Produto} - {a.Preco} - {a.Quantidade} - {a.Secao} - {a.Hipermercado}");
                        }
                        Console.ReadKey();
                        break;

                    case 5: //5 – Mostrar no ecran o total da soma de todos os preços finais
                        int soma = lst_auchan.Sum(x => x.Preco);
                        Console.WriteLine($"A soma total de todos os preços finais é {soma}.");
                        Console.ReadKey();
                        break;

                    case 6: //6 – Gerar um ficheiro com nome de utilizador que deverá conter todos os produtos do Hipermercado “Setúbal”
                        Console.WriteLine("Escreva o nome do ficheiro:");
                        string fich_nameS = Console.ReadLine();
                        FileInfo fich_setubal = new FileInfo(@"C:\ficheiros\"+fich_nameS+".txt");
                        StreamWriter escreverS = fich_setubal.CreateText();

                        foreach (Auchan a in lst_auchan.Where(x => x.Hipermercado.Contains("Setúbal")))
                        {
                            escreverS.WriteLine($"{a.Produto} - {a.Preco} - {a.Quantidade} - {a.Secao} - {a.Hipermercado}");
                        }
                        escreverS.Close();
                        Console.WriteLine("Ficheiro gerado com sucesso.");
                        Console.ReadKey();
                        break;

                    case 7: //7 – Gerar um ficheiro com nome de utilizador que deverá conter todos os produtos da seção “Peixaria”
                        Console.WriteLine("Escreva o nome do ficheiro:");
                        string fich_nameP = Console.ReadLine();
                        FileInfo fich_peixaria = new FileInfo(@"C:\ficheiros\" + fich_nameP + ".txt");
                        StreamWriter escreverP = fich_peixaria.CreateText();

                        foreach (Auchan a in lst_auchan.Where(x => x.Secao.Contains("Peixaria")))
                        {
                            escreverP.WriteLine($"{a.Produto} - {a.Preco} - {a.Quantidade} - {a.Secao} - {a.Hipermercado}");
                        }
                        escreverP.Close();
                        Console.WriteLine("Ficheiro gerado com sucesso.");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Erro. Esta opção não existe.");
                        Console.WriteLine("Escolha uma opção de 1 a 8.");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 8);

            Console.ReadKey();
        }
    }

    class Auchan
    {
        public void add_auchan(string a_prod, int a_preco, int a_quant, string a_secao, string a_mercado)
        {
            Produto = a_prod;
            Preco = a_preco;
            Quantidade = a_quant;
            Secao = a_secao;
            Hipermercado = a_mercado;
        }
        public string Produto { get; set; }
        public int Preco { get; set; }
        public int Quantidade { get; set; }
        public string Secao { get; set; }
        public string Hipermercado { get; set; }
        }
}
