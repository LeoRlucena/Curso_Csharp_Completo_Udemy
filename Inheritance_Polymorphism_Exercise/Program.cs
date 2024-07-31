using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using Inheritance_Polymorphism_Exercise.Entities;
using System.Globalization;

namespace Inheritance_Polymorphism_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler os dados de N
            //produtos(N fornecido pelo usuário).Ao final,
            //mostrar a etiqueta de preço de cada produto na
            //mesma ordem em que foram digitados.
            //Todo produto possui nome e preço. Produtos
            //importados possuem uma taxa de alfândega, e
            //produtos usados possuem data de fabricação.
            //Estes dados específicos devem ser
            //acrescentados na etiqueta de preço conforme
            //exemplo(próxima página).Para produtos
            //importados, a taxa e alfândega deve ser
            //acrescentada ao preço final do produto.
            //Favor implementar o programa conforme
            //projeto ao lado.

            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char p = char.Parse(Console.ReadLine());
                if (p == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Customs fee: ");
                    double cf = double.Parse(Console.ReadLine());
                    ImportedProduct importedProduct = new ImportedProduct(name, price, cf);
                    products.Add(importedProduct);
                }
                else if (p == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Product product = new Product(name, price);
                    products.Add(product);
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime m = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    UsedProduct usedProduct = new UsedProduct(name, price, m);
                    products.Add(usedProduct);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
