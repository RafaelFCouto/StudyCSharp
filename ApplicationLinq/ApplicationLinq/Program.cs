using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using ApplicationLinq.Entities;


namespace ApplicationLinq
{
    class Program
    {

        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();

            string path = Console.ReadLine();



            try
            {


                using(StreamReader sr = File.OpenText(path)) {
                
                    while(!sr.EndOfStream) {

                        string[] lines = sr.ReadLine().Split(',');

                        string nameProduct = lines[0];
                        double priceProduct = double.Parse(lines[1], CultureInfo.InvariantCulture);

                        products.Add(new Product(nameProduct, priceProduct));

                            
                    
                
                    }

                    var avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();

                    var v1 = products
                        .Where(p=> p.Price < avg)
                        .OrderByDescending(p => p.Name)
                        .Select(p => p.Name);
                    

                    Console.WriteLine("Average: "+ avg.ToString("F2", CultureInfo.InvariantCulture));

                    foreach(var item in v1)
                    {
                        Console.WriteLine(item);
                    }





                }

            }
            catch(IOException e)
            {

                Console.WriteLine("Error: " + e.Message);
            }






        }




    }
}