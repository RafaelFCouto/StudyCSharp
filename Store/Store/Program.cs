using System;
using System.Globalization;
using Store.Entities.Enum;
using Store.Entities;



namespace Store
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string nameClient = Console.ReadLine();
            Console.Write("Email: ");
            string emailClient = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDateClient = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter Order data: ");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int qtdItems = int.Parse(Console.ReadLine());

            Client client = new Client(nameClient, emailClient, birthDateClient);
            Order order = new Order(DateTime.Now,orderStatus, client);






            for (int i = 1; i <= qtdItems; i++)
            {

                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());
                Product product = new Product(nameProduct,priceProduct);
                OrderItem orderItem = new OrderItem(quantityProduct, priceProduct, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);


        }
    }




}