using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    class InjectPrinter:Printer
    {
        const int coef = 50;

        public InjectPrinter() : base(PrinterCategory.InjectPrinter) { }

        public override int GetPrintTime()
        {
            return coef;
        }
    }
}
