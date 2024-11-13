using BlackJack.Views;

namespace BlackJack.Models
{
    public class Hand (bool isDealer)
    {
        private List<Card> _hand = [];
        private int _score = 0;
        private bool _isDealer = isDealer;
        public List<Card> GetHand() => _hand;
        public void SetHand(List<Card> value) => _hand = value;

        public int CalculateScore()
        {
            var totalScore = 0;
            foreach (var card in _hand)
            {
                totalScore += card.Value;
            }

            return totalScore;
        }
    }
}
