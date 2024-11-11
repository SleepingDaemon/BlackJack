namespace BlackJack.Models
{
    public enum Suit
    {
        None,
        Hearts,
        Diamonds,
        Clubs,
        Spades,
    }

    public class Card
    {

        public Suit Suit { get; }
        public string Rank { get; }
        public int Value
        {
            get
            {
                return Rank switch
                {
                    "2" => 2,
                    "3" => 3,
                    "4" => 4,
                    "5" => 5,
                    "6" => 6,
                    "7" => 7,
                    "8" => 8,
                    "9" => 9,
                    "10" => 10,
                    "Jack" => 10,
                    "Queen" => 10,
                    "King" => 10,
                    "Ace" => 11,
                    _ => 0
                };
            }
        }

        public Card(Suit suit, string rank)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}
