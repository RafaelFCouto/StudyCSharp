using ProductStore.Entities;
using System;
using System.Globalization;



namespace ProductStore
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();


            Console.Write("Enter the number of products: ");
            int qtdProduct = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdProduct; i++) {

                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (typeProduct == 'c')
                {
                    products.Add(new Product(nameProduct, priceProduct));
                }
                else if(typeProduct == 'u')
                {
                    Console.Write("Manufature date (DD/MM/YYYY): ");
                    DateTime dateManufacture = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(nameProduct, priceProduct, dateManufacture));
                }
                else
                {
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(nameProduct, priceProduct, customsFee));
                }




            }

            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }







        }
    }
}