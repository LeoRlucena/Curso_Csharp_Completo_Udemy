using System.Runtime.ConstrainedExecution;
using Fixacao_Composicao.Entities;
using Fixacao_Composicao.Entities.Enums;
using System.Globalization;

namespace Fixacao_Composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Ler os dados de um pedido com N itens (N fornecido pelo usuário). Depois, mostrar um
            /// sumário do pedido conforme exemplo(próxima página).Nota: o instante do pedido deve ser
            /// o instante do sistema: DateTime.Now

            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);


            Console.Write("How many items to this order? ");
            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);         
        }
    }
}
