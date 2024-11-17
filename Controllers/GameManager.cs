using BlackJack.Models;
using BlackJack.Views;

namespace BlackJack.Controllers
{
    public class GameManager
    {
        private List<Player> _players;
        private Player? _dealer;
        private Deck _deck;
        public Player? CurrentPlayer { get; set; }
        public GameState GameState { get; private set; }
        public List<Player> GetPlayers() => _players;

        public GameManager(int playerNumbers, Deck deck, Player? dealer)
        {
            GameState = GameState.Playing;

            _players = new List<Player>();
            for (int i = 0; i < playerNumbers; i++)
            {
                _players.Add(new Player());
            }

            GameUI.NamePlayers(_players);

            _dealer = dealer ?? throw new ArgumentNullException(nameof(dealer));
            _deck   = deck   ?? throw new ArgumentNullException(nameof(deck));

            InitializeGame();
        }

        private void InitializeGame()
        {
            CurrentPlayer = _players.First();

            _deck = new Deck();
            _deck.Shuffle();
            _deck.Deal(_dealer.Hand, 2);
            _dealer.Hand.GetHand().First().FaceUp = false;

            foreach (Player player in _players)
            {
                _deck.Deal(player.Hand, 2);
            }

            GameUI.DisplayGame(_players, _dealer);
        }

        public void TakeTurn(Hand currentPlayer)
        {
            
        }

        public void SwitchTurn()
        {
            int currentPlayerIndex = 0;
            for (int turn = 0; turn < _players.Count; turn++)
            {
                Console.WriteLine(_players[currentPlayerIndex].Name + "'s turn: ");
                currentPlayerIndex = (currentPlayerIndex + 1) % _players.Count;
            }
        }

        private void WinningConditions()
        {

            
        }

        private void EndGame()
        {
            if (IsBlackJack(CurrentPlayer))
            {
                Console.WriteLine("BlackJack!! You won!");
            }
            else if(IsABust(CurrentPlayer))
            {
                Console.WriteLine(CurrentPlayer.Name + " busted!");
            }
        }

        public void Hit(Hand player)
        {
            _deck.Deal(player, 1);
            //GameUI.DisplayGame(_player, _dealer);
        }

        private bool IsBlackJack(Player player) => player.CalculateScore() == 21;

        private bool IsABust(Player player) => player.CalculateScore() > 21;

        private bool IsWinner(Player player, Player dealer) => player.CalculateScore() > dealer.CalculateScore() ||
                                                           dealer.CalculateScore() > player.CalculateScore();
    }
}
