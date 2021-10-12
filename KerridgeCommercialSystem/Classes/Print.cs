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

            var data1 = from item in items
                        where item.ItemCollection1 != null
                        select item;
            var data2 = from item in items
                        where item.ItemCollection2 != null
                        select item;
            var data3 = from item in items
                        where item.ItemCollection3 != null
                        select item;
            decimal totalTax = 0m;
            decimal total = 0m;

            foreach(var item in data1)
            {
                totalTax =+ item.Tax;
                total = +item.Price;
                Console.WriteLine("Output1\n================== :");
                output += (item.Imported) ? "\n" + data3.Count(f => item.Name.Contains(item.Name)) + " Imported  " + item.Name + " : " + item.Price.ToString() + "\nSales Taxes : " + decimal.Round(item.Tax,2) + "\nTotal : " + total :
                          "\n" + data1.Count(f => item.Name.Contains(item.Name)) + "  " + item.Name + " : " + item.Price.ToString() + "\nSales Taxes : " + decimal.Round(item.Tax, 2) + "\nTotal : " + total;


            }
            foreach (var item in data2)
            {
                totalTax = +item.Tax;
                total = +item.Price;
                Console.WriteLine("Output2\n================== :");
                output += (item.Imported) ? "\n" + data3.Count(f => item.Name.Contains(item.Name)) + " Imported  " + item.Name + " : " + item.Price.ToString() + "\nSales Taxes : " + decimal.Round(item.Tax, 2) + "\nTotal : " + total :
                          "\n" + data2.Count(f => item.Name.Contains(item.Name)) + "  " + item.Name + " : " + item.Price.ToString() + "\nSales Taxes : " + decimal.Round(item.Tax, 2) + "\nTotal : " + total;

            }
            foreach (var item in data3)
            {
                totalTax = +item.Tax;
                total = +item.Price;
                Console.WriteLine("Output3\n================== :");

                output += (item.Imported) ? "\n" + data3.Count(f => item.Name.Contains(item.Name)) + " Imported  " + item.Name + " : " + item.Price.ToString() + "\nSales Taxes : " + decimal.Round(item.Tax, 2) + "\nTotal : " + total :
                           "\n" + data3.Count(f => item.Name.Contains(item.Name)) + "  " + item.Name + " : " + item.Price.ToString() + "\nSales Taxes : " + decimal.Round(item.Tax, 2) + "\nTotal : " + total;
            }
            return output;
            
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
