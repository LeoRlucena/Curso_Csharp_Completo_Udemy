using System;
using System.Runtime.Intrinsics.X86;

namespace Exercicio_Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler dois números inteiros M e N, e depois ler
            // uma matriz de M linhas por N colunas contendo números inteiros,
            // podendo haver repetições.Em seguida, ler um número inteiro X que
            // pertence à matriz. Para cada ocorrência de X, mostrar os valores à
            // esquerda, acima, à direita e abaixo de X, quando houver, conforme
            // exemplo.

            string[] pos = Console.ReadLine().Split(' ');
            int n = int.Parse(pos[0]);
            int m = int.Parse(pos[1]);

            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int testN = int.Parse(Console.ReadLine());

            for (int i = 0;i < n; i++)
            {
                for (int j = 0;j < m; j++)
                {
                    if (mat[i, j] == testN)
                    {
                        Console.WriteLine($"Position {i}, {j}: ");
                       if (j > 0)
                        {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                       if (i > 0)
                        {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                       if (j < m - 1)
                        {
                            Console.WriteLine($"Right {mat[i, j + 1]}");
                        }
                       if (i < n - 1)
                        {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
