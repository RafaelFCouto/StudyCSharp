using System;
using System.Globalization;
using Company.Entities;




namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {


            List <Employee> employees = new List <Employee> ();







            Console.Write("Enter the number of employees: ");
            int qtdEmployee = int.Parse(Console.ReadLine());


            for (int i = 1; i <= qtdEmployee; i++) {

                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                string confereType = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hourWorked = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHours=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (confereType == "y")
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee emp = new OutsourceEmployee(name, hourWorked, valuePerHours,additionalCharge);
                    employees.Add(emp);
                }
                else
                {
                    Employee emp = new Employee(name, hourWorked, valuePerHours);
                    employees.Add(emp);
                }

            }

            Console.WriteLine("PAYMENT: ");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name} - $ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }










        }
    }
}