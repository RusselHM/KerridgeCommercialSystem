
using KerridgeCommercialSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KerridgeCommercialSystem.Classes
{
    class Calculate : ICalculate
    {
        public decimal ApplyBasicTax(string name, decimal price)
        {
            decimal newPrice = price + (price  * 0.10m);
            return newPrice;
        }

        public decimal ApplyImportTax(string name, decimal price)
        {
            decimal newPrice = price + (price * 0.05m);
            return newPrice;
        }
    }
}
