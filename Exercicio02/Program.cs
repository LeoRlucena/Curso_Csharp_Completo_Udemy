using System.Globalization;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.

            Funcionario F1 = new Funcionario();
            Funcionario F2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            F1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            F1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            F2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            F2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double SalarioMedio = (F1.Salario + F2.Salario) / 2;

            Console.WriteLine($"Salário médio = {SalarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
