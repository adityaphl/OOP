using System;

namespace InterfacePrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinterWindows printer;

            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. Laser Jet\n");

            Console.Write("Nomor Printer [1...3] : ");
            int nomerPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomerPrinter == 1)
                printer = new Epson();
            else if (nomerPrinter == 2)
                printer = new Canon();
            else if (nomerPrinter == 3)
                printer = new LaserJet();
            else
            {
                Console.WriteLine("\nInput Salah\n");
                return;
            }

            printer.Show();
            printer.Print();
        }
    }
}
