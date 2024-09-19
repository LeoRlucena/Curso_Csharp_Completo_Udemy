using Interface_IComparable.Entities;

namespace Interface_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";

            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!streamReader.EndOfStream)
                    {
                        list.Add(new Employee(streamReader.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
