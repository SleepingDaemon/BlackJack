namespace BlackJack.Models
{
    public class Deck
    {
        private List<Card> _deck;
        private Suit _suit;

        public Deck()
        {
            _deck = new List<Card>();

            switch (_suit)
            {
                case Suit.Hearts:
                    
                    break;
                case Suit.Diamonds:
                    break;
                case Suit.Clubs:
                    break;
                case Suit.Spades:
                    break;
                default:
                    break;

            }
        }
    }
}
