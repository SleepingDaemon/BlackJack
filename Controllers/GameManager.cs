namespace BlackJack.Controllers
{
    public class GameManager
    {
        private static GameManager? _instance;

        public static GameManager Instance
        {
            get { _instance ??= new GameManager(); return _instance; }
        }

        public GameManager()
        {
            _instance = this;
        }

    }
}
