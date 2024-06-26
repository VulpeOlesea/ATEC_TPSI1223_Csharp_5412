using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace exe15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            List<Chip7> lst_chip = new List<Chip7>();
            StreamReader ler = new StreamReader(@"C:\ficheiros\chip7.txt", Encoding.GetEncoding("iso-8859-1"));

            string linha = null;
            bool linha1 = true;

            while ((linha = ler.ReadLine()) != null)
            {
                if (linha1)
                {
                    linha1 = false;
                    continue;
                }
                Chip7 ch = new Chip7();

                string[] expressoes = linha.Split(new string[] { "&&&", "&&", "&" }, StringSplitOptions.None);

                if (expressoes.Length == 4)
                {
                    ch.add_chip(expressoes[0], double.Parse(expressoes[1]), int.Parse(expressoes[2]), expressoes[3]);
                    lst_chip.Add(ch);
                }
            }
            ler.Close();

            do
            {
                Console.Clear();
                Console.WriteLine("1 – Mostrar no ecran o conteúdo de todo o ficheiro");
                Console.WriteLine("2 – Mostrar no ecran apenas os produtos do armazém “Setúbal”");
                Console.WriteLine("3 – Mostrar no ecran apenas os produtos com preço final superior a 1000€");
                Console.WriteLine("4 – Mostrar no ecran apenas os produtos do Armazém do “Porto” e que sejam “ATI Radeon”");
                Console.WriteLine("5 – Mostrar no ecran o total da soma de todos os preços finais");
                Console.WriteLine("6 – Mostrar no ecran a média geral das quantidades de produtos");
                Console.WriteLine("7 – Gerar um ficheiro “Faro.txt” que deverá conter todos os produtos do armazém de “Faro”");
                Console.WriteLine("8 – Gerar um ficheiro “Monitores.txt” que deverá conter todos “Monitor”");
                Console.WriteLine("9 – Gerar um ficheiro “Portateis_ASUS.txt” que deverá conter todos os “Portatil ASUS”");
                Console.WriteLine("10 – Gerar um ficheiro “Preco_ordenado.txt que deverá conter os produtos ordenados por preço do mais caro para o mais barato");
                Console.WriteLine("11 – Permitir ao utilizador inserir uma linha no ficheiro “chip7”, pedindo ao utilizador o “nome do produto”, “preço”, “stock” e “loja”");
                Console.WriteLine("12 – Criar um ficheiro designado “encomendar_a_fornecedor.txt” com a seguinte estrutura: Produto&Preço&&Stock&&&Loja&&&&Encomendar.");
                Console.WriteLine("13 – Sair");

                Console.WriteLine("Qual a opção que pretende?");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: //1 – Mostrar no ecran o conteúdo de todo o ficheiro
                        foreach (Chip7 ch in lst_chip)
                        {
                            Console.WriteLine($"{ch.Produto} - {ch.Preco} - {ch.Stock} - {ch.Loja}");
                        }
                        Console.ReadKey();
                        break;

                    case 2: //2 – Mostrar no ecran apenas os produtos do armazém “Setúbal”
                         foreach (Chip7 ch in lst_chip.Where(x => x.Loja.Contains("Setúbal")))
                         {
                             Console.WriteLine($"{ch.Produto} - {ch.Preco} - {ch.Stock} - {ch.Loja}");
                        }
                         Console.ReadKey();
                         break;

                     case 3: //3 – Mostrar no ecran apenas os produtos com preço final superior a 1000€
                        foreach (Chip7 ch in lst_chip.Where(x => x.Preco > 1000))
                         {
                            Console.WriteLine($"{ch.Produto} - {ch.Preco} - {ch.Stock} - {ch.Loja}");
                        }
                         Console.ReadKey();
                         break;

                    case 4: //4 – Mostrar no ecran apenas os produtos do Armazém do “Porto” e que sejam “ATI Radeon”
                         foreach (Chip7 ch in lst_chip.Where(x => x.Loja.Contains("Porto") && x.Produto.Contains("ATI Radeon")))
                            {
                            Console.WriteLine($"{ch.Produto} - {ch.Preco} - {ch.Stock} - {ch.Loja}");
                          }
                        Console.ReadKey();
                        break;

                    case 5: //5 - Mostrar no ecran o total da soma de todos os preços finais
                        double soma = lst_chip.Sum(x => x.Preco);
                        Console.WriteLine($"A soma total de todos os preços finais é {soma}.");
                        Console.ReadKey();
                        break;

                    case 6: //6 – Mostrar no ecran a média geral das quantidades de produtos
                        double media = lst_chip.Average(x => x.Stock);
                        Console.WriteLine($"A média geral das quantidades de produtos é {media}.");
                        Console.ReadKey();
                        break;

                    case 7: //7 – Gerar um ficheiro “Faro.txt” que deverá conter todos os produtos do armazém de “Faro”
                        FileInfo fich = new FileInfo(@"C:\ficheiros\Faro.txt");
                        StreamWriter escrever = fich.CreateText();

                        foreach (Chip7 ch in lst_chip.Where(x => x.Loja.Contains("Faro")))
                        {
                            escrever.WriteLine($"{ch.Produto} - {ch.Preco} - {ch.Stock} - {ch.Loja}");
                        }
                        escrever.Close();
                        Console.WriteLine("Ficheiro gerado com sucesso.");
                        Console.ReadKey();
                        break;

                    case 8: //8 – Gerar um ficheiro “Monitores.txt” que deverá conter todos “Monitor …”
                        FileInfo fich2 = new FileInfo(@"C:\ficheiros\Monitores.txt");
                        StreamWriter escrever2 = fich2.CreateText();

                        foreach (Chip7 ch in lst_chip.Where(x => x.Produto.Contains("Monitor")))
                        {
                            escrever2.WriteLine($"{ch.Produto} - {ch.Preco} - {ch.Stock} - {ch.Loja}");
                        }
                        escrever2.Close();
                        Console.WriteLine("Ficheiro gerado com sucesso.");
                        Console.ReadKey();
                        break;

                    case 9: //9 – Gerar um ficheiro “Portateis_ASUS.txt” que deverá conter todos os “Portatil ASUS…”
                        FileInfo fich3 = new FileInfo(@"C:\ficheiros\Portateis_ASUS.txt");
                        StreamWriter escrever3 = fich3.CreateText();

                        foreach (Chip7 ch in lst_chip.Where(x => x.Produto.Contains("Portatil ASUS")))
                        {
                            escrever3.WriteLine($"{ch.Produto} - {ch.Preco} - {ch.Stock} - {ch.Loja}");
                        }
                        escrever3.Close();
                        Console.WriteLine("Ficheiro gerado com sucesso.");
                        Console.ReadKey();
                        break;

                    case 10: //10 – Gerar um ficheiro “Preco_ordenado.txt que deverá conter os produtos ordenados por preço do mais caro para o mais barato
                        FileInfo fich4 = new FileInfo(@"C:\ficheiros\Preco_ordenado.txt");
                        StreamWriter escrever4 = fich4.CreateText();

                        foreach (Chip7 ch in lst_chip.OrderByDescending(x => x.Preco))
                        {
                            escrever4.WriteLine($"{ch.Produto} - {ch.Preco} - {ch.Stock} - {ch.Loja}");
                        }
                        escrever4.Close();
                        Console.WriteLine("Ficheiro gerado com sucesso.");
                        Console.ReadKey();
                        break;

                    case 11:
                        Console.WriteLine("Para inserir o produto na lista escreva: ");
                        Console.WriteLine("O nome do produto: ");
                        string getNome = Console.ReadLine();
                        Console.WriteLine("Preço: ");
                        double getPreco = double.Parse(Console.ReadLine());
                        Console.WriteLine("Produto em stock: ");
                        int getStock = int.Parse(Console.ReadLine());
                        Console.WriteLine("Loja: ");
                        string getLoja = Console.ReadLine();

                        FileInfo fich5 = new FileInfo(@"C:\ficheiros\chip7.txt");
                        StreamWriter escrever5 = fich5.AppendText();
                        
                        escrever5.WriteLine($"{getNome}&{getPreco}&&{getStock}&&&{getLoja}");
                        
                        escrever5.Close();
                        Console.WriteLine("Produto inserido com sucesso.");
                        Console.ReadKey();
                        break;


                    case 12: //12 – Criar um ficheiro designado “encomendar_a_fornecedor.txt” com a seguinte estrutura: Produto&Preço&&Stock&&&Loja&&&&Encomendar O campo encomendar deve ser preenchido com “SIM”, se o stock atual for igual ou inferior a 3, e “NÃO” caso contrário.
                        FileInfo fich6 = new FileInfo(@"C:\ficheiros\encomendar_a_fornecedor.txt");
                        StreamWriter escrever6 = fich6.CreateText();

                        foreach (Chip7 ch in lst_chip)
                        {
                            if (ch.Stock <= 3)
                            {
                                string Encomendar = "SIM";
                                escrever6.WriteLine($"{ch.Produto}&{ch.Preco}&&{ch.Stock}&&&{ch.Loja}&&&&{Encomendar}");
                            }
                            else
                            {
                                string Encomendar = "NÃO";
                                escrever6.WriteLine($"{ch.Produto}&{ch.Preco}&&{ch.Stock}&&&{ch.Loja}&&&&{Encomendar}");
                            }
                        }
                        escrever6.Close();
                        Console.WriteLine("Ficheiro gerado com sucesso.");
                        Console.ReadKey();
                        break;

                    case 13:
                        break;

                    default:
                        Console.WriteLine("Erro. Esta opção não existe.");
                        Console.WriteLine("Escolha uma opção de 1 a 9.");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 13);

            Console.ReadKey();
        }
    }
    class Chip7
    {
        public void add_chip(string f_prod, double f_preco, int f_stock, string f_loja)
        {
            Produto = f_prod;
            Preco = f_preco;
            Stock = f_stock;
            Loja = f_loja;
        }
        public string Produto { get; set; }
        public double Preco { get; set; }
        public int Stock { get; set; }
        public string Loja { get; set; }
    }
}
    

