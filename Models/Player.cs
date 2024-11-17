using static System.Formats.Asn1.AsnWriter;

namespace BlackJack.Models
{
    public class Player
    {
        public string Name { get; set; } = String.Empty;
        public Hand Hand { get; set; }
        public int Score { get; set; }

        public Player()
        {
            Hand = new Hand();
        }

        public void Hit(Deck deck) => deck.Deal(Hand, 1);
        public void Stand()
        {

        }

        public int CalculateScore()
        {
            var totalScore = 0;
            foreach (var card in Hand.GetHand())
            {
                totalScore += card.Value;
            }

            Score = totalScore;

            return Score;
        }
    }
}
