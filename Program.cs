using BlackJack.Models;

Suit suit = Suit.None;

Card card = new Card(suit = Suit.Diamonds, "Jack");

Console.WriteLine(card.Value);

Console.ReadLine();