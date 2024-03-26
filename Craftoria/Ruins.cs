using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craftoria
{
    public class Ruins
    {
        public static void ExploreRuin()
        {
            Thread.Sleep(3000);
            Console.WriteLine("You discover ancient relics!");
            GameEngine.playerGold += 50;
            Console.WriteLine("You gained 50 gold. Total gold: " + GameEngine.playerGold);
        }
    }
}
