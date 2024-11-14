using BlackJack.Views;

namespace BlackJack.Models
{
    public class Hand
    {
        private List<Card> _hand = [];
        private string _name = string.Empty;
        private int _score = 0;

        public string Name { get => _name; set => _name = value; }
        public List<Card> GetHand() => _hand;

        public int CalculateScore()
        {
            var totalScore = 0;
            foreach (var card in _hand)
            {
                totalScore += card.Value;
            }

            _score = totalScore;

            return _score;
        }
    }
}
