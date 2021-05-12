using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new IPrinterService[]
            {
                new InjectPrinter(),
                new LaserPrinter(),
                new LedPrinter()
            };

            Console.WriteLine("We have:");

            foreach( var p in printer)
            {
                p.Print();
            }

            Console.ReadLine();
        }
    }
}
