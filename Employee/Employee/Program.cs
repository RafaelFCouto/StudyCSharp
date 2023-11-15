using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Employee.Entities;
using Employee.Entities.Enum;


namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            Console.Write("Enter Departament's name: ");
            string nameDepartament = Console.ReadLine();
            
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string nameEmployee = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(nameDepartament);
            Worker worker = new Worker(nameEmployee, level, baseSalary, department);


            Console.Write("How many contracts to this worker? ");
            int qtdContracts = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtdContracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date: (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hoursWorked = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(valuePerHour, hoursWorked, date);
                
                worker.AddContract(contract);

            }
            
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income: (MM/YYYY): ");
            string[] dateIncome = Console.ReadLine().Split('/');
            int month = int.Parse(dateIncome[0]);
            int year = int.Parse(dateIncome[1]);
    

            double incomeMonth= worker.Income(year, month);

            Console.WriteLine($"Name: {worker.Name}\nDepartament: {worker.Department.Name}\nIncome for {String.Join("/", dateIncome)}: {incomeMonth.ToString("F2",CultureInfo.InvariantCulture)}");

           


        }
    }
}