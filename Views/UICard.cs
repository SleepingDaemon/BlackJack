using BlackJack.Models;

namespace BlackJack.Views
{
    public class UICard
    {
        public static void DisplayCard(string rank, string suit, bool faceUp)
        {
            string topLine = "┌─────┐";
            string bottomeLine = "└─────┘";

            if (faceUp)
            {
                // Adjust padding based on the rank length
                string rankPadding = rank.Length == 1 ? " " : "";

                // Display each line of the card
                Console.WriteLine(topLine);
                Console.WriteLine($"│{rank}{rankPadding}   │"); // Rank in top left
                Console.WriteLine($"│  {suit}  │");             // Suit in center
                Console.WriteLine($"│   {rankPadding}{rank}│"); // Rank in bottom right
                Console.WriteLine(bottomeLine);
            }
            else
            {
                // Display each line of the card
                Console.WriteLine(topLine);
                Console.WriteLine($"│     │"); // Rank in top left
                Console.WriteLine($"│     │"); // Suit in center
                Console.WriteLine($"│     │"); // Rank in bottom right
                Console.WriteLine(bottomeLine);
            }
        }
    }
}
