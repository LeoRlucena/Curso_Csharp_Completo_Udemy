namespace extended_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 12, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
