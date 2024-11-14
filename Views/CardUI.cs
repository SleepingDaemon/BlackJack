using BlackJack.Models;
using System.Text;

namespace BlackJack.Views
{
    public class CardUI
    {
        public static string[] DisplayFaceCard(Card card)
        {
            // Adjust padding based on the rank length
            string rankPadding = card.Rank.Length == 1 ? " " : "";

            return
            [
                 "┌─────┐",
                $"│{card.Rank}{rankPadding}   │",
                $"│  {card.Suit}  │",
                $"│   {rankPadding}{card.Rank}│",
                 "└─────┘",
            ];
        }

        public static string[] DisplayDownCard(Card card)
        {
            // Adjust padding based on the rank length
            string rankPadding = card.Rank.Length == 1 ? " " : "";

            return
            [
                "┌─────┐",
                "│     │",
                "│     │",
                "│     │",
                "└─────┘",
            ];
        }

        public static void DisplayHand(List<Card> hand)
        {
            // Store the visual representation of each card in a list of string arrays
            List<string[]> cardDisplays = new List<string[]>();
            foreach (var card in hand)
            {
                if(card.FaceUp)
                    cardDisplays.Add(DisplayFaceCard(card)); // Assuming all cards are face-up
                else
                    cardDisplays.Add(DisplayDownCard(card));
            }

            // Print each row of all cards side-by-side
            for (int row = 0; row < cardDisplays[0].Length; row++)
            {
                foreach (var card in cardDisplays)
                {
                    Console.Write(card[row] + " "); // Print each row with spacing
                }
                Console.WriteLine(); // Move to the next line after each row
            }
        }
    }
}
