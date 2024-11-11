using BlackJack.Models;
using BlackJack.Views;

Card card = new("Diamond", "J", true);

Console.WriteLine(card.ToString());

Deck deck = new();
deck.Shuffle();
deck.Deal(new(), new());

UICard.DisplayCard(card.Rank, card.Suit, false);

Console.ReadLine();