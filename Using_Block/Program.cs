namespace Using_Block
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Temp\file1.txt";


            try
            {
                using (StreamReader sr = File.OpenText(path)) //OpenText instancia o FileStream e o StreamReader acima dele.
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
