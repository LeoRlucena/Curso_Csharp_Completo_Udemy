using System;
using System.Globalization;

namespace Exercicio_Dolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
            // uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
            // que a pessoa terá que pagar 6 % de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
            // para ser responsável pelos cálculos.

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.Conversor(dolares, cotacao);

            Console.WriteLine($"Valor a ser pago em reais = {total.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
