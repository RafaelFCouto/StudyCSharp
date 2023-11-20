using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using LinqApplication.Entities;
using System.Xml;
using System.Xml.Linq;

namespace LinqApplication
{

    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter Salary: ");
            double salarySearch = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            try
            {

                using(StreamReader sr = File.OpenText(path))
                {
                    while(!sr.EndOfStream)
                    {

                        string[] line = sr.ReadLine().Split(',');

                        string name = line[0];
                        string email = line[1];
                        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);


                        employees.Add(new Employee(name, email, salary));

                    }


                    var consult1 = employees.Where(e => e.Salary > salarySearch).OrderBy(e => e.Email).Select(e => e.Email); 

                    Console.WriteLine("Email of people whose salary is more than 2000.00:");
                    foreach (var item in consult1)
                    {
                        Console.WriteLine(item);
                    }

                    var consult2 = employees.Where(e => e.Name[0] == 'M').Sum(e=> e.Salary);


                    Console.WriteLine("Sum of salary of people whose name starts with 'M': " + consult2.ToString("F2", CultureInfo.InvariantCulture);




                }



            }

            catch (IOException e)
            {

                Console.WriteLine("ERROR: " + e.Message);

            }
            





        }
    }
}