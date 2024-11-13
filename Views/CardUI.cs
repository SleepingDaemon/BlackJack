using BlackJack.Models;
using System.Text;

namespace BlackJack.Views
{
    public class CardUI
    {
        public static void DisplayCard(Card card)
        {
            string topLine = "┌─────┐";
            string bottomeLine = "└─────┘";

            if (card.FaceUp)
            {
                // Adjust padding based on the rank length
                string rankPadding = card.Rank.Length == 1 ? " " : "";

                // Display each line of the card
                Console.WriteLine(topLine);
                Console.WriteLine($"│{card.Rank}{rankPadding}   │"); // Rank in top left
                Console.WriteLine($"│  {card.Suit}  │");             // Suit in center
                Console.WriteLine($"│   {rankPadding}{card.Rank}│"); // Rank in bottom right
                Console.WriteLine(bottomeLine);
            }
            else
            {
                Console.WriteLine(topLine);
                Console.WriteLine($"│     │"); 
                Console.WriteLine($"│     │"); 
                Console.WriteLine($"│     │"); 
                Console.WriteLine(bottomeLine);
            }
        }

        public static void DisplayHand(List<Card> hand)
        {
            foreach (Card card in hand)
            {
                Console.Write("");
                DisplayCard(card);
                Console.Write("");
            }

            Console.WriteLine();
        }
    }
}
