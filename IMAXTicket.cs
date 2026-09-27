using System;

namespace G_NET_65_OOP03
{
    public class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movieName, double price, bool is3D)
            : base(movieName, price)
        {
            Is3D = is3D;

            if (Is3D)
                Price += 30;
        }

        public override string ToString()
        {
            return base.ToString() + $" | IMAX 3D: {(Is3D ? "Yes" : "No")}";
        }
    }
}
