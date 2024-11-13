using BlackJack.Models;
using BlackJack.Views;

Hand player = new Hand(false);
Hand dealer = new Hand(true);

Deck deck = new();
deck.Shuffle();
deck.Deal(player, 2);
deck.Deal(dealer, 2);

CardUI.DisplayHand(dealer.GetHand());
CardUI.DisplayHand(player.GetHand());

Console.ReadLine();