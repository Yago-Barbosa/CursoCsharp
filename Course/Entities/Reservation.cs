using System;
using Course.Entities.Exceptions;

namespace Course.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(){ }

        // Agora com a criação da DomainException é possivel adiciona-lá no construtor
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-Out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                // se houver algum erro, será lancçada uma nova exceção personalizada e o método será "cortado"
                throw new DomainException("Reservation date for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-Out date must be after check-in date");
            }
            
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room " +
                RoomNumber +
                ", check-in: " +
                CheckIn.ToString("dd/MM/yyyy") +
                ", check-out: " +
                CheckOut.ToString("dd/MM/yyyy") +
                ", " +
                Duration() +
                " nights";
        }
    }
}
