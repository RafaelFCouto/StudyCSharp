using System;
using System.Globalization;
using Vector;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas objetos você deseja inserir? ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            string name;
            double price = 0.0;
            
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Insira o nome do produto {i+1}: ");
                name = Console.ReadLine();
                Console.Write($"Insira o preço do produto {i + 1}: ");
                price = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Product { Name = name, Price = price};
            }

            double sum = 0.0;

            for(int i = 0; i < n;i++)
            {
                sum += vect[i].Price;

            }

            double averangePrice = sum / n;


            Console.WriteLine("Averange Price = " +  averangePrice.ToString("F2", CultureInfo.InvariantCulture));



        }
    }

}