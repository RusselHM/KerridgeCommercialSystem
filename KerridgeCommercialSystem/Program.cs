using KerridgeCommercialSystem.Classes;
using KerridgeCommercialSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KerridgeCommercialSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            IInput _input = new Input();
            List<Item> myItems = new List<Item>();
            IPrint _print = new Print();

            Console.WriteLine("Please enter items to get the sum...");
            ConsoleKey response;
                
            do {
                Console.WriteLine("Enter Items for  purchase(Y/N)...");
                response = Console.ReadKey(false).Key;   // true is intercept key (dont show), false is show
                if (response != ConsoleKey.Enter)
                   myItems = _input.Batches();
            }
            while(response != ConsoleKey.Y && response != ConsoleKey.N);
            _print.Output(myItems);

            Console.Read();
            
        }
    }
}
