using KerridgeCommercialSystem.Enums;
using KerridgeCommercialSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KerridgeCommercialSystem.Classes
{
    public class Input : IInput
    {
        public List<Item> Batches()
        {
            List<Item> collection1 = new List<Item>();
            List<Item> collection2 = new List<Item>();
            List<Item> collection3 = new List<Item>();
            List<Item> collection = new List<Item>();
            ConsoleKey response;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter Items?(Y/N)...");
                response = Console.ReadKey(false).Key;
                Console.Clear();
                if (response != ConsoleKey.Enter)
                collection1 = this.Input1(collection1);
                collection.AddRange(collection1);
                collection2 = this.Input2(collection2);
                collection.AddRange(collection2);
                collection3 = this.Input3(collection3);
                collection.AddRange(collection3);
                return collection;

            }
            while (response != ConsoleKey.Y && response != ConsoleKey.N);
        }

        public  List<Item> Input1(List<Item> items)
        {
            string name = "", category = "";
            decimal price = 0.00m;
            bool imported = false;
            char importedChar = ' ';
            decimal tax =0m;
            ItemCategory type;
            Input input = new Input();
           
            ConsoleKey response;
            do
            {
                Console.Clear();
                Console.WriteLine("Input 1...");
                Console.WriteLine("======================================================");

                Console.WriteLine("Item Name...");
                 name = Console.ReadLine();

                
                Console.WriteLine("Choose Category..");
                string value = Console.ReadLine();
                if (value == ItemCategory.Books.ToString())
                    type = ItemCategory.Books;
                else if (value == ItemCategory.Food.ToString())
                    type = ItemCategory.Food;
                else if (value == ItemCategory.Medical.ToString())
                    type = ItemCategory.Medical;
                else
                    type = ItemCategory.Other;

  
                Console.WriteLine("Price...");
                price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Imported?(Y/N)...");
                importedChar = Convert.ToChar(Console.ReadLine());
                if (importedChar == 'Y' || importedChar == 'y')
                    imported = true;
                else
                    imported = false;
                Item _item = new Item(name, price, imported, type,tax);
             
                _item.ItemCollection1 = new List<Item>();
                items.Add(_item);
                _item.ItemCollection1 = items;
          
                Console.WriteLine("Enter Another?(Y/N)...");
                response = Console.ReadKey(false).Key;   
                if (response != ConsoleKey.Enter)
                    Console.WriteLine();
                if (response == ConsoleKey.Y)
                    this.Input1(_item.ItemCollection1);
                return items;
            }
            while (response != ConsoleKey.Y && response != ConsoleKey.N);
        }
        public List<Item> Input2(List<Item> items)
        {
            string name = "", category = "";
            decimal price = 0.00m;
            bool imported = false;
            char importedChar = ' ';
            decimal tax = 0m;
            ItemCategory type;
            Input input = new Input();

            ConsoleKey response;
            do
            {
                Console.Clear();
                Console.WriteLine("Input 2...");
                Console.WriteLine("======================================================");

                Console.WriteLine("Item Name...");
                name = Console.ReadLine();


                Console.WriteLine("Choose Category..");
                string value = Console.ReadLine();
                if (value == ItemCategory.Books.ToString())
                    type = ItemCategory.Books;
                else if (value == ItemCategory.Food.ToString())
                    type = ItemCategory.Food;
                else if (value == ItemCategory.Medical.ToString())
                    type = ItemCategory.Medical;
                else
                    type = ItemCategory.Other;


                Console.WriteLine("Price...");
                price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Imported?(Y/N)...");
                importedChar = Convert.ToChar(Console.ReadLine());
                if (importedChar == 'Y' || importedChar == 'y')
                    imported = true;
                else
                    imported = false;
                Item _item = new Item(name, price, imported, type, tax);

                _item.ItemCollection2 = new List<Item>();
                items.Add(_item);
                _item.ItemCollection2 = items;
           
                Console.WriteLine("Enter Another?(Y/N)...");
                response = Console.ReadKey(false).Key;
                if (response != ConsoleKey.Enter)
                    Console.WriteLine();
                if (response == ConsoleKey.Y)
                    this.Input2(_item.ItemCollection2);
                return items;
            }
            while (response != ConsoleKey.Y && response != ConsoleKey.N);
        }
        public List<Item> Input3(List<Item> items)
        {
            string name = "", category = "";
            decimal price = 0.00m;
            bool imported = false;
            char importedChar = ' ';
            decimal tax = 0m;
            ItemCategory type;
            Input input = new Input();

            ConsoleKey response;
            do
            {
                Console.Clear();
                Console.WriteLine("Input 3...");
                Console.WriteLine("======================================================");

                Console.WriteLine("Item Name...");
                name = Console.ReadLine();


                Console.WriteLine("Choose Category..");
                string value = Console.ReadLine();
                if (value == ItemCategory.Books.ToString())
                    type = ItemCategory.Books;
                else if (value == ItemCategory.Food.ToString())
                    type = ItemCategory.Food;
                else if (value == ItemCategory.Medical.ToString())
                    type = ItemCategory.Medical;
                else
                    type = ItemCategory.Other;


                Console.WriteLine("Price...");
                price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Imported?(Y/N)...");
                importedChar = Convert.ToChar(Console.ReadLine());
                if (importedChar == 'Y' || importedChar == 'y')
                    imported = true;
                else
                    imported = false;
                Item _item = new Item(name, price, imported, type, tax);

                _item.ItemCollection3 = new List<Item>();
                items.Add(_item);
                _item.ItemCollection3 = items;
              
                Console.WriteLine("Enter Another?(Y/N)...");
                response = Console.ReadKey(false).Key;
                if (response != ConsoleKey.Enter)
                    Console.WriteLine();
                if (response == ConsoleKey.Y)
                    this.Input3(_item.ItemCollection3);
                return items;
            }
            while (response != ConsoleKey.Y && response != ConsoleKey.N);
        }

    }
}
