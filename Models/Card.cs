namespace BlackJack.Models
{
    public class Card(string suit, string rank, bool faceUp)
    {
        public string Suit { get; } = suit;
        public string Rank { get; } = rank;
        public bool FaceUp { get; set; } = faceUp;
        public int Value
        {
            get
            {
                return Rank switch
                {
                    "2"  => 2,
                    "3"  => 3,
                    "4"  => 4,
                    "5"  => 5,
                    "6"  => 6,
                    "7"  => 7,
                    "8"  => 8,
                    "9"  => 9,
                    "10" => 10,
                    "J"  => 10,
                    "Q"  => 10,
                    "K"  => 10,
                    "A"  => 11,
                    _    => 0
                };
            }
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }
}
