using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate___Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Traveller Rifaf = new Traveller("Rifaf", "male", 22);
            BUS Greenline = new BUS(500, "Onlie", "khulna");
            Color_Printer color_Printer = new Color_Printer();

            Booking_Agency booking_Agency = new Booking_Agency();
            booking_Agency.Ticket_Generator(Greenline, Rifaf);
            booking_Agency.Ticket_printer(color_Printer, Greenline, Rifaf);

            Console.WriteLine("\n\n");

            BUS Shohag= new BUS(1000, "online", "Dhaka");
            Traveller Alif = new Traveller("Alif", "male", 21);
            Grayscale_Printer grayscale_Printer = new Grayscale_Printer();
            booking_Agency.Ticket_Generator(Shohag, Alif);
            booking_Agency.Ticket_printer(grayscale_Printer, Shohag,Alif);
        }
    }
}
