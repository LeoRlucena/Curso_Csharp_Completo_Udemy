using System.Drawing;
using System.Globalization;

namespace Exercicio_Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler os valores da largura e altura de um retângulo. Em
            // seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe
            // como mostrado no projeto ao lado.

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e a altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"ÁREA: {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO: {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL: {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
