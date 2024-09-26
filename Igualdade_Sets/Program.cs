using Igualdade_Sets.Entities;

namespace Igualdade_Sets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> products = new HashSet<Product>();
            products.Add(new Product("TV", 900.0));
            products.Add(new Product("Notebook", 1300.0));

            HashSet<Point> points = new HashSet<Point>();
            points.Add(new Point(3, 4));
            points.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1300.0);
            Console.WriteLine(products.Contains(prod));

            Point P = new Point(5, 10);
            Console.WriteLine(points.Contains(P)); 
        }
    }
}
