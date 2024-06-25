using System.Globalization;

namespace Exercicio_Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler os dados de um funcionário (nome,
            // salário bruto e imposto). Em seguida, mostrar os dados do
            // funcionário(nome e salário líquido).Em seguida, aumentar o salário
            // do funcionário com base em uma porcentagem dada(somente o
            // salário bruto é afetado pela porcentagem) e mostrar novamente os
            // dados do funcionário.Use a classe projetada abaixo.

            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionário: {func}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);

            Console.WriteLine("Dados atualizados: " + func);

        }
    }
}
