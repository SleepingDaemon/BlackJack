using BlackJack.Models;
using System.Numerics;

namespace BlackJack.Views
{
    public class GameUI
    {
        public static void DisplayGame(List<Player> players, Player dealer)
        {
            Console.Clear();
            Console.WriteLine($"{dealer?.Name}");
            CardUI.DisplayHand(dealer.Hand.GetHand());
            Console.WriteLine("-------------------");
            foreach (Player player in players)
            {
                CardUI.DisplayHand(player.Hand.GetHand());
                Console.WriteLine($"{player.Name}");
                Console.WriteLine("Card Points: " + player.CalculateScore());
                Console.WriteLine();
                Console.WriteLine("-------------------");
            }
        }

        public static void NamePlayers(List<Player> players)
        {
            for (int i = 0; i < players.Count; i++)
            {
                Console.Write("Enter name for Player" + (i + 1) + ": ");
                players[i].Name = Console.ReadLine();
            }
        }
    }
}
