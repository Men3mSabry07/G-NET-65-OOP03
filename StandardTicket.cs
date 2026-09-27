using System;

namespace G_NET_65_OOP03
{
    public class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string movieName, double price, string seatNumber)
            : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Seat: {SeatNumber}";
        }
    }
}
