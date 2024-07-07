namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p;      //Não precisa instanciar
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);

        }
    }
}
