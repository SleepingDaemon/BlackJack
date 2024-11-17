using BlackJack.Views;

namespace BlackJack.Models
{
    public class Hand
    {
        private List<Card> _hand = [];
        private int _score = 0;

        public List<Card> GetHand() => _hand;
    }
}
