using KerridgeCommercialSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KerridgeCommercialSystem.Classes
{
    public class Print : IPrint
    {
        public string Output(List<Item> items)
        {
            string output = "";
            List<Item> collection1 = new List<Item>();
            List<Item> collection2 = new List<Item>();
            List<Item> collection3 = new List<Item>();

            collection1 = items.Select(x => x.ItemCollection1).FirstOrDefault();
            collection2 = items.Select(x => x.ItemCollection2).FirstOrDefault();
            collection3 = items.Select(x => x.ItemCollection3).FirstOrDefault();
            decimal totalTax = 0m;
            decimal total = 0m;

            foreach(var item in collection1)
            {
                totalTax =+ item.Tax;
                total = +item.Price;
                Console.WriteLine("Output1\n================== :");
                output += "\n" + item.Name.Count() + "  " + item.Type.ToString() + " : " + item.Price.ToString() + "\n Sales Taxes : " + item.Tax + "\n Total : " + total;


            }
            foreach (var item in collection2)
            {
                totalTax = +item.Tax;
                total = +item.Price;
                Console.WriteLine("Output2\n================== :");
                output += "\n" + item.Name.Count() + "  " + item.Type.ToString() + " : " + item.Price.ToString() + "\n Sales Taxes : " + item.Tax + "\n Total : " + total;

            }
            foreach (var item in collection3)
            {
                totalTax = +item.Tax;
                total = +item.Price;
                Console.WriteLine("Output3\n================== :");
                output += "\n" + item.Name.Count() + "  " + item.Type.ToString() + " : " + item.Price.ToString() + "\n Sales Taxes : " + item.Tax + "\n Total : " + total;
               
            }
            return output;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
