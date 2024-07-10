using Microsoft.Win32;
using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace Vetores_ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A dona de um pensionato possui dez quartos para alugar para estudantes,
            //sendo esses quartos identificados pelos números 0 a 9.
            //Quando um estudante deseja alugar um quarto, deve - se registrar o nome
            //e email deste estudante.
            //Fazer um programa que inicie com todos os dez quartos vazios, e depois
            //leia uma quantidade N representando o número de estudantes que vão
            //alugar quartos(N pode ser de 1 a 10).Em seguida, registre o aluguel dos
            //N estudantes. Para cada registro de aluguel, informar o nome e email do
            //estudante, bem como qual dos quartos ele escolheu(de 0 a 9).Suponha
            //que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
            //um relatório de todas ocupações do pensionato, por ordem de quarto,
            //conforme exemplo.


            Student[] vect = new Student[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Student(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms: ");
            for (int i = 0;i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine($"{i}: {vect[i]}");
                }
            }
        }
    }
}
