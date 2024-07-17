using System.Runtime.Intrinsics.Arm;

namespace ExercicioResolvido_Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler um número inteiro N e uma matriz de
            // ordem N contendo números inteiros.Em seguida, mostrar a diagonal
            // principal e a quantidade de valores negativos da matriz.

            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                

                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0;i < N; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();
            
            int count = 0;
            for(int i = 0; i < N; i++)
            {
                for (int j = 0;j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Negative numbers: {count}");
        }
    }
}
