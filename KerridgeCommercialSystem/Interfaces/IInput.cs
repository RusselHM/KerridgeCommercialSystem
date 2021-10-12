using KerridgeCommercialSystem.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace KerridgeCommercialSystem.Interfaces
{
    interface IInput
    {
        public List<Item> Batches();
        List<Item> Input1(List<Item> items);
        List<Item> Input2(List<Item> items);
        List<Item> Input3(List<Item> items);
    }
}
