using KerridgeCommercialSystem.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace KerridgeCommercialSystem.Enums
{
    interface IItem
    {
        public List<Item> CalculateTax(List<Item> items);
       
    }
}
