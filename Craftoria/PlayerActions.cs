using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craftoria
{
    public class PlayerActions
    {
        public static void DrinkPotion()
        {
            Thread.Sleep(2000);
            Console.WriteLine("You feel a surge of energy after drinking the potion.");
            Console.WriteLine("Your health is restored!");
        }
    }
}
