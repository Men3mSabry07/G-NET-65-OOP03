namespace G_NET_65_OOP03
{
    public enum Types { Standard, VIP, IMAX }
    public struct Seat
    {
        public char Row { get; set; }
        public int Number { get; set; }
        public Seat(char r, int n)
        {
            Row = r;
            Number = n;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             * a) Composition
             * b) Association
             * c) Inheritance
             * d) Aggregation
             * e) Dependency
             */
            #endregion

            #region Q2
            /*
             * a) Yes
             *    cannot
             * b) protected internal >> same assembly OR child
                  private protected >> same assembly AND child
             * c) sealed class >> prevents inheritance.
                  sealed method >> prevents overriding.
             * d) Yes sealed prevents inheritance not object creation
             */
            #endregion


            // a. Create a Cinema and open it
            Cinema cinema = new Cinema();
            cinema.CinemaName = "Cinema 1";

            Console.WriteLine("========== Cinema Opened ==========");
            cinema.OpenCinema();

            // b. Create one ticket of each type & Add tickets to Cinema
            StandardTicket standardTicket = new StandardTicket("Inception", 120, "A-5");

            VIPTicket vipTicket = new VIPTicket("Avengers", 200, true);

            IMAXTicket imaxTicket = new IMAXTicket("Dune", 180, false);
            
            cinema.AddTicket(standardTicket);
            cinema.AddTicket(vipTicket);
            cinema.AddTicket(imaxTicket);

            // c. Print all tickets
            Console.WriteLine("\n========== All Tickets ==========");
            cinema.PrintAllTickets();

            // Statistics
            Console.WriteLine("\n========== Statistics ==========");
            Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");

            // d. Close the Cinema
            Console.WriteLine("\n========== Cinema Closed ==========");
            cinema.CloseCinema();
        }
    }
}
