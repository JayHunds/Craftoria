using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craftoria
{
    public class QuestSystem
    {
        public static void AssignRandomQuest()
        {
            Console.WriteLine("NPC: Hello, adventurer! I have a quest for you.");

            Random rand = new Random();
            int randomQuest = rand.Next(1, 6);

            switch (randomQuest)
            {
                case 1:
                    QuestRetrieveArtifact();
                    break;
                case 2:
                    QuestDefeatMonster();
                    break;
                case 3:
                    QuestFindLostItem();
                    break;
                case 4:
                    HelpLostTraveler();
                    break;
                case 5:
                    QuestExploreCave();
                    break;
            }
        }

        private static void QuestRetrieveArtifact()
        {
            Console.WriteLine("Quest: Retrieve the legendary artifact hidden in the cave of wonders.");
            Console.Write("Will you accept this quest? (yes/no): ");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("NPC: Great! Bring me the artifact, and you shall be rewarded handsomely.");
                Thread.Sleep(3000);
                Console.WriteLine("You found the legendary artifact!");
                GameEngine.playerGold += 50;
                Console.WriteLine("You gained 50 gold. Total gold: " + GameEngine.playerGold);
            }
            else
            {
                Console.WriteLine("NPC: Very well. Farewell, adventurer.");
            }
        }

        private static void QuestDefeatMonster()
        {
            Console.WriteLine("Quest: A fearsome monster has been terrorizing our village. Can you defeat it?");
            Console.Write("Will you accept this quest? (yes/no): ");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("NPC: Thank you! The monster lurks in the nearby forest. Be careful!");
                Thread.Sleep(5000);
                Console.WriteLine("You defeated the monster and saved the village!");
                GameEngine.playerGold += 80;
                Console.WriteLine("You received 80 gold as a reward. Total gold: " + GameEngine.playerGold);
            }
            else
            {
                Console.WriteLine("NPC: We understand. The village remains in peril.");
            }
        }

        private static void QuestFindLostItem()
        {
            Console.WriteLine("Quest: Can you help me find my lost family heirloom? It's somewhere in the forest.");
            Console.Write("Will you accept this quest? (yes/no): ");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("NPC: Thank you so much!");
                Thread.Sleep(4000);
                Console.WriteLine("You found the lost family heirloom!");
                GameEngine.PlayerInventory = InventorySystem.AddToInventory("Family Heirloom", GameEngine.PlayerInventory);
                Console.WriteLine("You returned the heirloom to the NPC.");
            }
            else
            {
                Console.WriteLine("NPC: Oh, I see... I'll keep searching on my own then.");
            }
        }

        private static void HelpLostTraveler()
        {
            Console.WriteLine("Quest: A traveler has lost their way. Can you guide them back to safety?");
            Console.Write("Will you accept this quest? (yes/no): ");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("NPC: Thank you! The lost traveler awaits your help.");
                Thread.Sleep(4000);
                Console.WriteLine("You safely guide the lost traveler back to civilization!");
                GameEngine.playerGold += 40;
                Console.WriteLine("You received 40 gold as a reward. Total gold: " + GameEngine.playerGold);
            }
            else
            {
                Console.WriteLine("NPC: Very well. The lost traveler remains in peril.");
            }
        }

        private static void QuestExploreCave()
        {
            Console.WriteLine("Quest: Explore the mysterious cave to uncover its secrets.");
            Console.Write("Will you accept this quest? (yes/no): ");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("NPC: Excellent! Beware of the dangers that lie within.");
                Thread.Sleep(5000);
                Console.WriteLine("You bravely explore the cave and find hidden treasures!");
                GameEngine.playerGold += 60;
                Console.WriteLine("You received 60 gold as a reward. Total gold: " + GameEngine.playerGold);
            }
            else
            {
                Console.WriteLine("NPC: Perhaps another time, then.");
            }
        }
    }
}
