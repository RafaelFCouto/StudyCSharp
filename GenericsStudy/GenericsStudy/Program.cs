using System;
using System.Globalization;
using GenericsStudy.Entities;
using GenericsStudy.Services;
using System.Collections.Generic;




namespace GenericsStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PrintService<string> printService = new PrintService<string>();



            Console.Write("How many values? ");
            int qtdValues =int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdValues; i++)
            {
                string value = Console.ReadLine();

                printService.AddValue(value);

            }

            printService.Print();
            Console.WriteLine();

            Console.WriteLine("First: "+ printService.FirstValue());
            

           
            List<Products> products = new List<Products>();


            Console.Write("Enter number products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Product (Name, Price): ");
                string[] product = Console.ReadLine().Split(",");
                
                string name = product[0];
                
                double price = double.Parse(product[1], CultureInfo.InvariantCulture);

                products.Add(new Products(name, price));
            }


            CalculationService calculationService = new CalculationService();

            Products p = calculationService.MaxPrice(products);

            Console.WriteLine("Most expansive: ");
            Console.WriteLine(p);

            


            Client a = new Client {Name = "Maria" , Email = "maria@gmail.com"};
            Client b = new Client {Name = "Alex" , Email = "maria@gmail.com"};

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.Email == b.Email);
            Console.WriteLine(a.Name == b.Name);

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            

            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            foreach (string s in set)
            {
                Console.WriteLine(s);
            }

            


           SortedSet<int> a = new SortedSet<int>() {0,2,4,5,6,8,10 };
           SortedSet<int> b = new SortedSet<int>() {5, 6,7,8,9,10};




            //union

            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            // Intersection


            SortedSet<int> d = new SortedSet<int>(a);

            d.IntersectWith(b);
           
            PrintCollection(d);

           // difference

            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
            */


            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);

            Console.WriteLine(a.Contains(prod));

            Point p = new Point(3, 4);

            Console.WriteLine(b.Contains(p));

        }

        static void PrintCollection <T> (IEnumerable <T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}