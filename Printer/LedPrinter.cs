using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    class LedPrinter : Printer
    {
        const int coef = 70;
        public LedPrinter() : base(PrinterCategory.LedPrinter) { }

        public override int GetPrintTime()
        {
            return coef;
        }
    }
}
