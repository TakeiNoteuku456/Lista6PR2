using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ex;

            Console.WriteLine("========Menu========");
            Console.WriteLine("Exercício 1");
            Console.WriteLine("Exercício 2");
            Console.WriteLine("Exercício 3");
            Console.WriteLine("Exercício 4");
            Console.WriteLine("Exercício 5");
            Console.WriteLine("Exercício 6");

            Ex = int.Parse(Console.ReadLine());

            switch (Ex)
            {
                case 1:
                    int totalItens = 0, repet = 2;
                    double totalCompra = 0;

                    for (;repet != 1 ; )//laço infinito
                    {
                        Console.Write("Informe a quantidade de itens: ");
                        int quantidade = int.Parse(Console.ReadLine());

                        if (quantidade <= 0)
                        {
                            Console.WriteLine($"Total de itens: {totalItens}");
                            Console.WriteLine($"Total da compra: R${totalCompra}");
                            break;
                        }

                        Console.Write("Informe o preço do produto: R$");
                        double preco = double.Parse(Console.ReadLine());

                        totalItens += quantidade;
                        totalCompra += quantidade * preco;
                    }
                    break;

                case 2:
                    string nomedoproduto;
                    int Numerodeitens = 0, parada = 2;
                    double Preçodoproduto, menorValor, maiorvalor;

                    menorValor = float.MaxValue;
                    maiorvalor = float.MinValue;

                    Console.WriteLine("=== Controle de Estoque da Mercearia Bom Preço ===\n");

                    for (;parada != 1 ; )//laço infinito
                        Console.Write("Informe o nome do produto (ou digite 0 para encerrar): ");
                        nomedoproduto = Console.ReadLine();
                        
                        Console.Write("Informe a quantidade de intens (ou digite 0 para encerrar): ");
                        Numerodeitens = int.Parse(Console.ReadLine());
                    
                        Console.Write("Informe a quantidade de intens (ou digite 0 para encerrar): ");
                        Preçodoproduto = int.Parse(Console.ReadLine());

                    float total = Numerodeitens
                        * Preçodoproduto;
                    if (total < )
                    {
                        Console.WriteLine("\nCadastro de produtos encerrado.");
                        break;
                                           
                    }
                    break;
            }
        }
    }
}
