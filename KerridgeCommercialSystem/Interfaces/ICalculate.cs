using System;
using System.Collections.Generic;
using System.Text;

namespace KerridgeCommercialSystem.Interfaces
{
    interface ICalculate
    {
        public decimal ApplyBasicTax(string Name, decimal price);
        public decimal ApplyImportTax(string Name, decimal price);
    }
}
