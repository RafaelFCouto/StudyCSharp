using System;
using System.Globalization;
using System.Collections.Generic;

namespace List{ 
    
    class Program {
    
        static void Main(string[] args)
        {

            /*
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine( "List Count: " + list.Count);


            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine( "Fist 'A': "+ s1 );

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos2);

            Console.WriteLine("-------------------------------");

            List<string> list2 = list.FindAll( x=> x.Length == 5);

            foreach(string item in list2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------");

            list.Remove("Alex");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------");

            list.RemoveAll(x=> x[0]=='M');
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------");
            */


            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int numRegistration = int.Parse(Console.ReadLine());

            for (int i = 0; i < numRegistration; i++)
            {

                Console.WriteLine($"Emplyoee #{i+1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();

            }


            
            Console.Write("Enter the employee id that will have salary increase: ");
            int idFind = int.Parse(Console.ReadLine());


            Employee emp = employees.Find(x => x.Id == idFind);
            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This ID does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee item in employees)
            {
                Console.WriteLine(item);
            }



        }



    }




}