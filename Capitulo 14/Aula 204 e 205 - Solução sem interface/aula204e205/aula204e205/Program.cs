using aula204e205.Entities;
using System;
using System.Globalization;
using aula204e205.Services; 

namespace aula204e205
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter rental data. ");
            Console.Write("Car model: ");
            string model = Console.ReadLine();


            Console.Write("Pickup (dd/MM/yyyy hh:ss): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/MM/yyyy hh:ss): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day);


            rentalService.ProcessInvoice(carRental);


            Console.WriteLine("INVOICE: ");
            Console.Write(carRental.Invoice);




        }

    }

}