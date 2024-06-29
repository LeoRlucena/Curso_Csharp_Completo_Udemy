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

            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("");

            Console.WriteLine(p.GetNome());

        }
    }
}
