using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using System;
using System.Globalization;

namespace Exercicio_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
            // (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
            // ano.Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
            // para o aluno obter o mínimo para ser aprovado(que é 60 pontos). Você deve criar uma classe Aluno para resolver
            // este problema.

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.nota1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine($"NOTA FINAL: {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }
    }
}
