using System;
using System.Globalization;

namespace Problema_Exemplo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler os dados de um produto em estoque (nome,
            // preço e quantidade no estoque). Em seguida, mostrar os dados do produto,
            // Realizar uma entrada no estoque e mostrar novamente os dados do produto,
            // Realizar uma saída no estoque e mostrar novamente os dados do produto.
            // Criar uma classe "Produto" com os atributos: Nome, Preco, Quantidade.
            // Métodos: ValorTotalEmEstoque(), AdicionarProdutos(int), RemoverProdutos(int).

            
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco, quantidade);

            Produto p2 = new Produto() { Nome = "TV", Preco = 500.00, Quantidade = 20 };

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem removidos: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
