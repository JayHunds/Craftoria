using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craftoria
{
    public class CombatSystem
    {
        public static void FightGoblins()
        {
            Thread.Sleep(3000);
            Console.WriteLine("You defeated the goblins and gained some loot!");
            GameEngine.playerGold += 30;
            Console.WriteLine("You gained 30 gold. Total gold: " + GameEngine.playerGold);
        }

        public static void ConfrontBandits()
        {
            Thread.Sleep(4000);
            Console.WriteLine("You bravely confront the bandits and defeat them!");
            Console.WriteLine("You discover their hidden stash and loot it.");
            GameEngine.playerGold += 60;
            Console.WriteLine("You gained 60 gold. Total gold: " + GameEngine.playerGold);
        }
    }
}
