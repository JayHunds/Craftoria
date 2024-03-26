using Craftoria;
using System;
using System.Threading;

public static class GameEngine
{
    public static int playerGold { get; private set; } = 100;
    public static string playerName = "";
    public static string[] playerInventory = new string[0];

    public static void StartGame()
    {
        Console.WriteLine("Welcome to the mystical land of Craftoria!");
        Console.WriteLine("Your journey begins now, " + playerName + "!");

        DisplayOptions();
    }

    private static void DisplayOptions()
    {
        Console.WriteLine("\nWhat would you like to do?");
        Console.WriteLine("1. Explore Craftoria");
        Console.WriteLine("2. Visit a Merchant");
        Console.WriteLine("3. Talk to an NPC");
        Console.WriteLine("4. Quit");
        Console.Write("\nEnter your choice: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                ExploreCraftoria();
                break;
            case "2":
                VisitMerchant();
                break;
            case "3":
                TalkToNPC();
                break;
            case "4":
                Console.WriteLine("Thank you for playing Legends of Craftoria! Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice! Please choose a valid option.");
                DisplayOptions();
                break;
        }
    }

    private static void ExploreCraftoria()
    {
        Console.WriteLine("You venture forth into the unknown...");
        Thread.Sleep(2000);
        Random rand = new Random();
        int randomEvent = rand.Next(1, 9);

        switch (randomEvent)
        {
            case 1:
                Console.WriteLine("You discover a hidden treasure!");
                playerGold += 50;
                Console.WriteLine("You gained 50 gold. Total gold: " + playerGold);
                break;
            case 2:
                Console.WriteLine("You encounter a group of goblins!");
                Console.WriteLine("Prepare for battle!");
                CombatSystem.FightGoblins();
                break;
            case 3:
                Console.WriteLine("You find an ancient ruin!");
                Console.WriteLine("Do you dare to explore it?");
                Console.Write("Enter 'yes' to explore, anything else to continue: ");
                string exploreChoice = Console.ReadLine();
                if (exploreChoice.ToLower() == "yes")
                {
                    Ruins.ExploreRuin();
                }
                break;
            case 4:
                Console.WriteLine("You stumble upon a hidden dungeon!");
                Console.WriteLine("Will you enter and face its challenges?");
                Console.Write("Enter 'yes' to enter, anything else to continue: ");
                string enterDungeonChoice = Console.ReadLine();
                if (enterDungeonChoice.ToLower() == "yes")
                {
                    Dungeons.ExploreDungeon();
                }
                break;
            case 5:
                Console.WriteLine("You find a rare resource!");
                Console.WriteLine("You add it to your inventory.");
                playerInventory = InventorySystem.AddToInventory("Rare Resource", playerInventory);
                break;
            case 6:
                Console.WriteLine("You encounter a lost traveler!");
                Console.WriteLine("Will you help them find their way?");
                Console.Write("Enter 'yes' to help, anything else to continue: ");
                string helpChoice = Console.ReadLine();
                if (helpChoice.ToLower() == "yes")
                {
                    QuestSystem.HelpLostTraveler();
                }
                break;
            case 7:
                Console.WriteLine("You find a mysterious potion!");
                Console.WriteLine("Will you drink it?");
                Console.Write("Enter 'yes' to drink, anything else to continue: ");
                string drinkChoice = Console.ReadLine();
                if (drinkChoice.ToLower() == "yes")
                {
                    PlayerActions.DrinkPotion();
                }
                break;
            case 8:
                Console.WriteLine("You encounter a bandit camp!");
                Console.WriteLine("Will you confront the bandits?");
                Console.Write("Enter 'yes' to confront, anything else to continue: ");
                string confrontChoice = Console.ReadLine();
                if (confrontChoice.ToLower() == "yes")
                {
                    CombatSystem.ConfrontBandits();
                }
                break;
        }

        DisplayOptions();
    }

    private static void VisitMerchant()
    {
        Console.WriteLine("You approach a merchant's stall...");
        Thread.Sleep(2000);

        Console.WriteLine("Merchant: Welcome, traveler! What would you like to buy?");
        Console.WriteLine("1. Health Potion - 20 gold");
        Console.WriteLine("2. Sword of Power - 100 gold");
        Console.WriteLine("3. Exit");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                if (playerGold >= 20)
                {
                    playerGold -= 20;
                    playerInventory = InventorySystem.AddToInventory("Health Potion", playerInventory);
                    Console.WriteLine("You bought a Health Potion. Remaining gold: " + playerGold);
                }
                else
                {
                    Console.WriteLine("You don't have enough gold to buy a Health Potion.");
                }
                break;
            case "2":
                if (playerGold >= 100)
                {
                    playerGold -= 100;
                    playerInventory = InventorySystem.AddToInventory("Sword of Power", playerInventory);
                    Console.WriteLine("You bought a Sword of Power. Remaining gold: " + playerGold);
                }
                else
                {
                    Console.WriteLine("You don't have enough gold to buy a Sword of Power.");
                }
                break;
            case "3":
                break;
            default:
                Console.WriteLine("Invalid choice! Please choose a valid option.");
                break;
        }

        DisplayOptions();
    }

    private static void TalkToNPC()
    {
        Console.WriteLine("You approach an NPC...");
        Thread.Sleep(2000);

        QuestSystem.AssignRandomQuest();

        DisplayOptions();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        playerName = Console.ReadLine();
        Console.WriteLine("\nWelcome, " + playerName + ", to Legends of Craftoria!");

        StartGame();
    }
}