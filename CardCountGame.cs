using System;
using System.Collections.Generic;
using System.Linq;

namespace HW2
{
	public class CardCountGame
	{


		public static Deck deck;


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
			CardCountHand playerOne = new  CardCountHand  ();
			CardCountHand playerTwo = new  CardCountHand  ();



			for (int i = 0; i < 8; i++) 
			{
				playerOne.hand.Add(deck.DealOne ());
				playerTwo.hand.Add(deck.DealOne ());

			}

			Console.WriteLine("Hand 1: " + playerOne);

			//deck.Shuffle ();

			//Console.WriteLine("Hand 1: " + playerOne);
			Console.WriteLine("Hand 2: " + playerTwo);





			//Console.WriteLine("Hand 2: " + playerTwo);
			Console.WriteLine("Hand 1 Score: " + playerOne.EvaluateHand());
			Console.WriteLine("Hand 2 Score: " + playerTwo.EvaluateHand());
			Console.WriteLine("Cards remaining in deck: " + deck.GetCardsRemaining());
		}

	}
}

