using BlackJack.Views;
using System.Collections;

namespace BlackJack.Models
{
    public class Deck
    {
        private Stack<Card> _deck;
        private readonly string[] _suits = ["♥", "♦", "♣", "♠"];
        private readonly string[] _ranks = ["2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"];

        public Deck()
        {
            _deck = [];

            foreach (var suit in _suits)
            {
                foreach (var rank in _ranks)
                {
                    Card card = new(suit, rank, true);
                    _deck.Push(card);                    
                }
            }
        }

        public Stack<Card> GetDeck() => _deck;

        public void Shuffle()
        {
            var deckArray = _deck.ToArray();
            Card[] shuffledCards = new Random().GetItems(deckArray, _deck.Count);
            _deck = new Stack<Card>(shuffledCards);
        }

        public void Deal(Hand player, int amount, bool isDealer = false)
        {
            if (player == null) return;

            for (int i = 0; i < amount; i++)
            {
                player.GetHand().Add(_deck.Pop());
            }
        }
    }
}
