using System;
using System.Globalization;

namespace Vetores_ProblemaExemplo_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um número inteiro N e a altura de N pessoas.
            //Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas
            //pessoas.

            int n = int.Parse(Console.ReadLine());

            double[] alturas = new double[n];
            
            for (int i = 0; i < n; i++)
            {
                alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0;i < n; i++)
            {
                sum += alturas[i];
            }

            double avg = sum / n;

            Console.WriteLine($"AVERAGE HEIGHT = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
