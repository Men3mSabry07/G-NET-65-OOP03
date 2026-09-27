using System;

namespace G_NET_65_OOP03
{
    public class Ticket
    {
        private string MovieName;
        public string movieName
        {
            get { return MovieName; }
            set
            {
                if (value != null && value != "")
                {
                    MovieName = value;
                }
            }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        private static int count = 0;
        public int TicketId  { get; }
        public double PriceAfterTax => price + (price * 14 / 100);

        public Ticket(string MovieName, double price)
        {
            count++;
            TicketId = count;

            this.MovieName = MovieName;
            this.price = price;
        }
        public override string ToString()
        {
            return $"Ticket #{TicketId} | {movieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
        }
        public static int GetTotalTickets() {
            return count;
        }
    }
}