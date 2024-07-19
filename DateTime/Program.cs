using System;
using System.Globalization;

namespace Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DateTime d1 = DateTime.Now;           
            // DateTime d2 = new DateTime(2018, 11, 25); // ano, mes, dia
            // DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03); //ano, mes, dia, hora, minuto, segundo
            // DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 03, 500);
            // DateTime d5 = DateTime.Today; // dia de hoje sem horas
            // DateTime d6 = DateTime.UtcNow; // horas no fuso de greenwich (global)

            // Console.WriteLine(d1);
            // Console.WriteLine(d2);
            // Console.WriteLine(d3);
            // Console.WriteLine(d4);
            // Console.WriteLine(d5);
            // Console.WriteLine(d6);

            // DateTime d1 = DateTime.Parse("2000-08-15");
            // DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");

            // DateTime d3 = DateTime.Parse("15/08/2000");
            // DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");

            // Console.WriteLine(d1);
            // Console.WriteLine(d2);
            // Console.WriteLine(d3);

            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }
    }
}
