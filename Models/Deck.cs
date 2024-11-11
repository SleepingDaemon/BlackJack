using BlackJack.Views;

namespace BlackJack.Models
{
    public class Deck
    {
        private List<Card> _deck;
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
                    _deck.Add(card);                    
                }
            }
        }

        public void Shuffle()
        {
            var deckArray = _deck.ToArray();
            Card[] shuffledCards = new Random().GetItems(deckArray, _deck.Count);
            _deck = [.. shuffledCards];
        }

        public void Deal(int playerCount)
        {
            List<Card>[] playerCards = new List<Card>[playerCount];
            List<Card> dealerCards = new();

            Stack<Card> shuffledDeck = new Stack<Card>();
            for (int i = 0; i < _deck.Count; i++)
            {
                shuffledDeck.Push(_deck[i]);
                //Console.WriteLine(shuffledDeck.Peek());
            }

            // First Card
            foreach(var player in playerCards)
            {
                player.Add(shuffledDeck.Pop());
            }

            dealerCards.Add(shuffledDeck.Pop());
            dealerCards[0].FaceUp = false;

            // Second Card
            foreach (var player in playerCards)
            {
                player.Add(shuffledDeck.Pop());
            }

            dealerCards.Add(shuffledDeck.Pop());

            UICard.DisplayCard(dealerCards[0].Rank, dealerCards[0].Suit, true);
            Console.WriteLine(" ");
            UICard.DisplayCard(dealerCards[1].Rank, dealerCards[1].Suit, false);
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
