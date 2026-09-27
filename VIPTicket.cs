using System;

namespace G_NET_65_OOP03
{
    public class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; set; } = 50m;

        public VIPTicket(string movieName, double price, bool loungeAccess) : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP";
        }
    }

}
