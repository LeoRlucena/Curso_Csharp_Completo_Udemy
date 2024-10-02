namespace linq_introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = { 1, 2, 3 };

            // Define the query expression
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            // Execute the query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
