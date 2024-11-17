using BlackJack.Controllers;
using BlackJack.Models;
using BlackJack.Views;

bool _isPlaying = true;

Console.Write("How many players will play? ");
string? input = Console.ReadLine();
int numberOfPlayers = int.Parse(input);

Deck deck = new Deck();
Player dealer = new Player() { Name = "Jazzy the Dealer" };
GameManager gameManager = new GameManager(numberOfPlayers, deck, dealer);

while (_isPlaying)
{

}

Console.ReadLine();