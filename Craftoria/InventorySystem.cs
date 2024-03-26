using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craftoria
{
    public class InventorySystem
    {
        public static string[] AddToInventory(string item, string[] inventory)
        {
            Array.Resize(ref inventory, inventory.Length + 1);
            inventory[inventory.Length - 1] = item;
            return inventory;
        }
    }

}
