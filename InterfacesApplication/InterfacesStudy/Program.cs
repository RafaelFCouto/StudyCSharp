using System;
using System.Globalization;
using InterfacesStudy.Entities;
using InterfacesStudy.Services;



namespace InterfaceApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Rental data: ");
            Console.Write("Car Model: ");

            string vehicle = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

            

            Console.Write("Enter price per hours: ");
            double pricePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per days: ");
            double pricePerDays = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            RentalCar rental = new RentalCar(start, finish, new Vehicle(vehicle));
            RentalService rentalService = new RentalService(pricePerHours, pricePerDays, new BrazilTaxService());

            rentalService.ProcessInvoice(rental);
            Console.WriteLine();
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(rental.Invoice);




        }
    } 
}

