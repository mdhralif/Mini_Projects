using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate___Print
{
    public class Grayscale_Printer : Iprint
    {
        public void Print(Ticket ticket,Traveller traveller)
        {
            Console.WriteLine("Traveller name: " + traveller.name + "\nGrayscale print");
        }
    }
}
