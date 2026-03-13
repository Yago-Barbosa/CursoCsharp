using Course.Entities;
using Course.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaExcecaoPersonalizada
    {
        public static void Exercicio()
        {
            // As três soluções estão no github do professor Nelio
            // https://github.com/acenelio/exceptions1-csharp
            // Versão usando exceções personalizadas - Solução "Boa"
            try
            {
                Console.Write("Room Number: ");
                int roomNumber = int.Parse(Console.ReadLine()!);
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine()!);
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine()!);

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine()!);
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine()!);

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException error)
            {
                Console.WriteLine("Error in Reservation: " + error.Message);
            }
            catch (FormatException error)
            {
                Console.WriteLine("Format Error: " + error.Message);
            }
            catch (Exception error)
            {
                Console.WriteLine("Unexpected Error: " + error.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Execution Finished...");
            }
        }
    }
}
