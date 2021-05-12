using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    public enum PrinterCategory
    {
        InjectPrinter = 1,
        LaserPrinter = 2,
        LedPrinter = 3
    }
    abstract class Printer: IPrinterService
    {
        public PrinterCategory printerCategory;
  
        public Printer(PrinterCategory printerCategory)
        {
            this.printerCategory = printerCategory;
        }

        public PrinterCategory PrinterCategory { get; set; }
        
        public abstract int GetPrintTime();
        public void Print()
        {
            Console.WriteLine(printerCategory.ToString() + " prints at a speed " + GetPrintTime().ToString() +" of pages per minute");
        }
    }
}
