namespace DateTime_ISO8601
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            //Console.WriteLine("d1: " + d1);
            //Console.WriteLine("d1 King: " + d1.Kind);
            //Console.WriteLine("d1 ToLocal: " + d1.ToLocalTime());
            //Console.WriteLine("d1 ToUtc: " + d1.ToUniversalTime());
            //Console.WriteLine();
            //Console.WriteLine("d2: " + d2);
            //Console.WriteLine("d2 King: " + d2.Kind);
            //Console.WriteLine("d2 ToLocal: " + d2.ToLocalTime());
            //Console.WriteLine("d2 ToUtc: " + d2.ToUniversalTime());
            //Console.WriteLine();
            //Console.WriteLine("d3: " + d3);
            //Console.WriteLine("d3 King: " + d3.Kind);
            //Console.WriteLine("d3 ToLocal: " + d3.ToLocalTime());
            //Console.WriteLine("d3 ToUtc: " + d3.ToUniversalTime());
            //Console.WriteLine();

            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 King: " + d1.Kind);
            Console.WriteLine("d1 ToLocal: " + d1.ToLocalTime());
            Console.WriteLine("d1 ToUtc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 King: " + d2.Kind);
            Console.WriteLine("d2 ToLocal: " + d2.ToLocalTime());
            Console.WriteLine("d2 ToUtc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH-mm-ssZ"));

        }
    }
}
