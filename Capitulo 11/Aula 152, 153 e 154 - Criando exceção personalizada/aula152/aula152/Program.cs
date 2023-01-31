using System;
using aula152.Entities;

namespace aula152
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Check-in date: ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date: ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());


            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine();

            Console.WriteLine("Enter data to update the reservation.");

            Console.Write("Check-in date: ");
            checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date: ");
            checkOut = DateTime.Parse(Console.ReadLine());

            
            reservation.UpdateDates(checkIn, checkOut);                
            Console.WriteLine("Reservation: " + reservation);

        }

    }

}