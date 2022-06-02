using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSHaoUP
{
    public class StoreInventory
    {
        public List<Game> InventoryList { get; set; }
        public StoreInventory()
        {
            InventoryList = new List<Game>();
            InventoryList.Add(new PUBG());
            InventoryList.Add(new PokemonLetsGoEvee());
            InventoryList.Add(new CyberPunk());
            InventoryList.Add(new BattleField());
        }

        public void PrintInventory(string command)
        {
            if (command == "1")
            {
                Print(InventoryList);
            }
            else if (command == "2")
            {
                Print(ListPhysicalItems());
            }
            else
            {
                Print(ListDownloadable());
            }
        }

        public void Print(List<Game> gamesToPrint)
        {
            foreach(var game in gamesToPrint)
            {
                game.PrintGameNameAndPrice();
            }
        }

        public List<Game> ListPhysicalItems()
        {
            // for å finne alle elementene i InventoryList som selges i fysisk format 
            return InventoryList.Where(GameItem => GameItem is IPhysicalCopy).ToList();
        }

        public List<Game> ListDownloadable()
        {             
            return InventoryList.Where(GameItem => GameItem is IDownloadable).ToList();
        }
    }
}
