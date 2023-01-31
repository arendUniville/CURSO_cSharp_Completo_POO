using System;
using aula152.Entities;
using aula152.Entities.Exceptions;

namespace aula152
{

    class Program
    {

        static void Main(string[] args)
        {


            try
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

            }catch(DomainException e)
            {

                Console.WriteLine("Error in reservation: " + e.Message);

            }catch(FormatException e)
            {

                Console.WriteLine("Format error: " + e.Message);

            }catch(Exception e) 
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
                    
            }

        }

    }

}