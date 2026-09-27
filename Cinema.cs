using System;

namespace G_NET_65_OOP03
{
    public class Cinema
    {
        public string CinemaName { get; set; }

        private Projector projector = new Projector();

        private Ticket[] tickets = new Ticket[20];

        public Ticket this[int index]
        {
            get
            {
                if (index >= 0 && index < tickets.Length)
                    return tickets[index];

                return null;
            }

            set
            {
                if (index >= 0 && index < tickets.Length)
                    tickets[index] = value;
            }
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }

            return false;
        }

        public void PrintAllTickets()
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] != null)
                {
                    Console.WriteLine(tickets[i]);
                }
            }
        }

        public void OpenCinema()
        {
            projector.Start();
        }

        public void CloseCinema()
        {
            projector.Stop();
        }

        public Ticket GetMovie(string movieName)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] != null &&
                    tickets[i].movieName == movieName)
                {
                    return tickets[i];
                }
            }

            return null;
        }
    }
}