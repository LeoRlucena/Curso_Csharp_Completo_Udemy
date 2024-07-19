using System.Security.Cryptography;

namespace Operacoes_TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t);

            Console.WriteLine("Days: " + t.Days);

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1.Add(t2); // Soma
            TimeSpan dif = t1.Subtract(t2); //Diferença
            TimeSpan mult = t2.Multiply(2.0); // Multiplicação
            TimeSpan div = t2.Divide(2.0); //Divisão
            
        }
    }
}
