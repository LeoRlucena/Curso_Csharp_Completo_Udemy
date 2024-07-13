namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Bob", "Alex"};

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
