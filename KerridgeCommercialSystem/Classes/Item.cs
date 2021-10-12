using KerridgeCommercialSystem.Enums;
using KerridgeCommercialSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KerridgeCommercialSystem.Classes
{
    public class Item : IItem
    {
        private decimal tax;
        ICalculate _calculate = new Calculate();
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Tax
        {
            get
            {
                return tax;
            }
            set
            {
                if (this.Type != ItemCategory.Other)
                    tax =  this.Price * 0.10m;
                if (this.Imported)
                {
                    tax = this.Price * 0.05m;
                }
            }
        }
        public bool Imported { get; set; }
        public ItemCategory Type { get; set; }
        public List<Item> ItemCollection1 { get; set; }
        public List<Item> ItemCollection2 { get; set; }
        public List<Item> ItemCollection3 { get; set; }
        public Item(string _name,decimal _price,bool _imported,ItemCategory _type,decimal _tax)
        {
            this.Name = _name;
            this.Price = _price;
            this.Imported = _imported;
            this.Type = _type;
            this.Tax = _tax;

        }
     

        public List<Item> CalculateTax(List<Item> items)
        {
            List<Item> myCurrentList = new List<Item>();
            
            foreach (var item in items)
            {
                switch (item.Type)
                {
                    case ItemCategory.Books:
                        if (item.Imported)
                        {
                            item.Price =_calculate.ApplyImportTax(item.Name, item.Price);
                            myCurrentList.Add(item);
                        }
                        break;
                    case ItemCategory.Food:
                        if (item.Imported)
                        {
                            item.Price = _calculate.ApplyImportTax(item.Name, item.Price);
                            myCurrentList.Add(item);
                        }
                        break;
                    case ItemCategory.Medical:
                        if (item.Imported)
                        {
                            item.Price = _calculate.ApplyImportTax(item.Name, item.Price);
                            myCurrentList.Add(item);
                        }
                        break;
                    default:
                        item.Price = _calculate.ApplyBasicTax(item.Name, item.Price);
                        if (item.Imported)
                        {
                            item.Price = _calculate.ApplyImportTax(item.Name, item.Price);
                            myCurrentList.Add(item);
                        }
                        break;
                       

                }
                
            }
            return myCurrentList;
        }
    }
    
    
    
}
