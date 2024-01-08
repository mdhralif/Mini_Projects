using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate___Print
{
    //public enum color
    //{
    //    Full_color, Grayscale
    //}
    public class Booking_Agency
    {
        public void Ticket_Generator(Ticket ticket, Traveller traveller)
        {
            ticket.generate_ticket(traveller);
        }

        public void Ticket_printer(Iprint printer,Ticket ticket,Traveller traveller)
        {
            printer.Print(ticket, traveller);
        }
    }
}
