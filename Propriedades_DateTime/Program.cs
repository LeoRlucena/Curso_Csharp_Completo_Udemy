﻿namespace Propriedades_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DateTime d = new DateTime(2001, 08, 15, 13, 45, 58, 275);

            // Console.WriteLine(d);
            // Console.WriteLine("1) Date: " + d.Date);
            // Console.WriteLine("2) Day: " + d.Day);
            // Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            // Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            // Console.WriteLine("5) Hour: " + d.Hour);
            // Console.WriteLine("6) Kind: " + d.Kind);
            // Console.WriteLine("7) Millisecond: " + d.Millisecond);
            // Console.WriteLine("8) Minute: " + d.Minute);
            // Console.WriteLine("9) Month: " + d.Month);
            // Console.WriteLine("10) Second: " + d.Second);
            // Console.WriteLine("11) Ticks: " + d.Ticks);
            // Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            // Console.WriteLine("13) Year: " + d.Year);

            //DateTime d = new DateTime(2001, 08, 15, 13, 45, 58);

            //Console.WriteLine(d.ToLongDateString());
            // Console.WriteLine(d.ToLongTimeString());
            //Console.WriteLine(d.ToShortDateString());
            //Console.WriteLine(d.ToShortTimeString());
            //Console.WriteLine(d.ToString());

            // string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            //Console.WriteLine(s6);

            //string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            //Console.WriteLine(s7);

            // DateTime d = new DateTime(2001, 08, 15, 13, 45, 58);

            // DateTime d2 = d.AddHours(2);

            // DateTime d3 = d.AddMinutes(3);

            // Console.WriteLine(d);
            // Console.WriteLine(d2);
            // Console.WriteLine(d3);

            DateTime d1 = new DateTime(2000, 10, 15);

            DateTime d2 = new DateTime(2000, 10, 18);

            TimeSpan t = d2.Subtract(d1);

            Console.WriteLine(t);
        }
    }
}
