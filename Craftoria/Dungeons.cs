using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craftoria
{
    public class Dungeons
    {
        public static void ExploreDungeon()
        {
            Thread.Sleep(5000);
            Console.WriteLine("You delve deep into the dungeon and face its challenges.");
            Console.WriteLine("After a fierce battle, you emerge victorious!");
            GameEngine.playerInventory = InventorySystem.AddToInventory("Treasure Chest", GameEngine.playerInventory);
            Console.WriteLine("You obtained a treasure chest!");
        }
    }

}
