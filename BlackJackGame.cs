using System;
using System.Collections.Generic;
using System.Linq;

namespace HW2
{
	public class BlackJackGame
	{
		public static Deck deck;


	

		public BlackJackGame ()
		{
			

		}

		public void PlayGame()
		{
			deck = new Deck ();

			for (int x = 0; x < Suit.VALUES.Count; x++)
			{
				for (int y = 0; y < Rank.VALUES.Count; y++)
				{
					Card card = new Card(Suit.VALUES[x], Rank.VALUES[y]);
					deck.AddCard(card);
				}
			}

			deck.Shuffle ();

			BlackJackHand player = new  BlackJackHand  ();
			BlackJackHand computer = new  BlackJackHand  ();


			Console.WriteLine ("Welcome to Blackjack!");
			String input;
			int i = 0;

			do{
				
				player.hand.Add(deck.DealOne ());
				Console.WriteLine("You have been dealt the " + player.GetCardAtIndex(i));
				Console.WriteLine("Current Score: " + player.EvaluateHand());
 
				Console.WriteLine ("Hit or Stand (H/S)?");
				input = Console.ReadLine ();

		
				i++;

			}
			while (input.ToUpper() == "H" );
			int j = 0;
			do{
				
				computer.hand.Add(deck.DealOne ());
				Console.WriteLine("Computer has been dealt the " + computer.GetCardAtIndex(j));
				Console.WriteLine("Current Score: " + computer.EvaluateHand());

				j++;
			}
			while (computer.EvaluateHand() < 17);

			if (player.EvaluateHand () > 21) {
				Console.WriteLine ("You have exceeded 21, you lose.");

			} else if (computer.EvaluateHand () > 21) {
				Console.WriteLine ("The Computer has exceeded 21, you win.");
			} else {
				if (player.CompareTo (computer) == 1) {
					Console.WriteLine ("The player wins!");
				} else if (player.CompareTo (computer) == -1) {
					Console.WriteLine ("The computer wins!");
				} else {
					Console.WriteLine ("Hands are equal, the dealer wins!");
				}

			}
		}
	}
}

