using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    class LaserPrinter : Printer
    {
        const int coef = 100;
        public LaserPrinter() : base(PrinterCategory.LaserPrinter) { }

        public override int GetPrintTime()
        {
            return coef;
        }
    }
}
