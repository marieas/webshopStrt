using System;

namespace WebSHaoUP
{
    class Program
    {        
        static void Main(string[] args)
        {
            var inventory = new StoreInventory();
            Console.WriteLine("HVa vil du se? " + "Alle spill: 1, nedlastbare: 3, fysiske spill: 2");
            var command = Console.ReadLine();

            inventory.PrintInventory(command);
        }
    }
}
