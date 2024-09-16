using System.Reflection.Metadata;
using System.IO;

namespace StreamWriterAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"c:\Temp\file1.txt";
            string targetpath = @"c:\Temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);

                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
