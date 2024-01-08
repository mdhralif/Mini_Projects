using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate___Print
{
    public class BUS : Ticket
    {
        public BUS(int price, string source, string destination/*, color color*/)
        {
            this.price = price;
            this.source = source;
            this.destination = destination;
            //this.color = color;
        }
        public override void generate_ticket(Traveller traveller)
        {
            Console.WriteLine("Generating Ticket for BUS of "+traveller.name);
        }

        //public override void print_ticket(Ticket ticket,Traveller traveller)
        //{
        //    if(color==color.Full_color)
        //    {
        //        Console.WriteLine("Traveller name: " + traveller.name + "\nFull_color print");
        //    }
        //    else if(color==color.Grayscale)
        //    {
        //        Console.WriteLine("Traveller name: " + traveller.name + "\nGrayscale print");
        //    }
            
        //}
            
        
    }
}
