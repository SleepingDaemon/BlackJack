using BlackJack.Models;
using BlackJack.Views;

namespace BlackJack.Controllers
{
    public class GameManager
    {
        public enum GameState { Playing, Won, Lost }

        private Deck _deck;
        private Hand? _player;
        private Hand? _dealer;

        private bool _isDealer = false;
        private bool _switchPlayer = false;
        private GameState _gameState;

        public Hand? CurrentHand { get; set; }

        public GameManager(Hand player, Hand dealer)
        {
            _player = player;
            _dealer = dealer;
            CurrentHand = _dealer;

            _deck = new Deck();
            _deck.Shuffle();
            _deck.Deal(_player, 2);
            _deck.Deal(_dealer, 2);
            _dealer.GetHand().First().FaceUp = false;

            _gameState = GameState.Playing;

            DisplayGame();
        }

        private void DisplayGame()
        {
            Console.Clear();
            Console.WriteLine($"{_dealer?.Name}");
            CardUI.DisplayHand(_dealer.GetHand());
            Console.WriteLine("-------------------");
            CardUI.DisplayHand(_player.GetHand());
            Console.WriteLine($"{_player.Name}");
            Console.WriteLine("Card Points: " + _player.CalculateScore());
        }

        public void SwitchTurn() => _switchPlayer = !_switchPlayer;

        public void Hit(Hand player)
        {
            _deck.Deal(player, 1);
            DisplayGame();
        }

        private bool IsBlackJack(Hand player)
        {
            int score = player.CalculateScore();
            return score == 21;
        }

        private bool IsABust(Hand player)
        {
            int score = player.CalculateScore();
            return score > 21;
        }

        private bool Won(Hand player, Hand dealer)
        {
            int score = player.CalculateScore();
            int dealerScore = dealer.CalculateScore();
            return score > dealerScore;
        }
    }
}
