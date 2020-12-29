using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePrinter
{
    class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("\nEpson printer dimension : 21*17");
        }

        public void Print()
        {
            Console.WriteLine("Epson printer printing...\n");
        }
    }
}
