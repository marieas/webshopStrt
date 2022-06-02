using System;
using System.Collections.Generic;
using System.Text;

namespace WebSHaoUP
{
    public class Game
    {
        public string GameName { get; set; }
        public int Price { get; set; }
        public string Id { get; set; }

        public void PrintGameNameAndPrice()
        {
            Console.WriteLine($"Item: {GameName} Price: {Price} ID: {Id}");
        }
    }
}
