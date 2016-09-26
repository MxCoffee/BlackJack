using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
	public class CardCountGame
	{


		public static Deck deck;
		public static Card c1;
		public static Card c2;
		public static Card c3;
		public static Card c4;
		public static Card c5;
		public static Card c6;
		public static Card c7;
		public static Card c8;
		public static Card c9;
		public static Card c10;
		public static Card c11;
		public static Card c12;
		public static Card c13;
		public static Card c14;
		public static Card c15;
		public static Card c16;
		public static Card c17;
		public static Card c18;
		public static Card c19;
		public static Card c20;
		public static Card c21;
		public static Card c22;
		public static Card c23;
		public static Card c24;
		public static Card c25;
		public static Card c26;
		public static Card c27;
		public static Card c28;
		public static Card c29;
		public static Card c30;
		public static Card c31;
		public static Card c32;
		public static Card c33;
		public static Card c34;
		public static Card c35;
		public static Card c36;
		public static Card c37;
		public static Card c38;
		public static Card c39;
		public static Card c40;
		public static Card c41;
		public static Card c42;
		public static Card c43;
		public static Card c44;
		public static Card c45;
		public static Card c46;
		public static Card c47;
		public static Card c48;
		public static Card c49;
		public static Card c50;
		public static Card c51;
		public static Card c52;


		public void PlayGame()
		{
			deck = new Deck ();



			c1 = new Card (Suit.CLUBS, Rank.TWO);
			c2 = new Card (Suit.DIAMONDS, Rank.TWO);
			c3 = new Card (Suit.HEARTS, Rank.TWO);
			c4 = new Card (Suit.SPADES, Rank.TWO);

			c5 = new Card (Suit.CLUBS, Rank.THREE);
			c6 = new Card (Suit.DIAMONDS, Rank.THREE);
			c7 = new Card (Suit.HEARTS, Rank.THREE);
			c8 = new Card (Suit.SPADES, Rank.THREE);

			c9 = new Card (Suit.CLUBS, Rank.FOUR);
			c10 = new Card (Suit.DIAMONDS, Rank.FOUR);
			c11 = new Card (Suit.HEARTS, Rank.FOUR);
			c12 = new Card (Suit.SPADES, Rank.FOUR);

			c13 = new Card (Suit.CLUBS, Rank.FIVE);
			c14 = new Card (Suit.DIAMONDS, Rank.FIVE);
			c15 = new Card (Suit.HEARTS, Rank.FIVE);
			c16 = new Card (Suit.SPADES, Rank.FIVE);

			c17 = new Card (Suit.CLUBS, Rank.SIX);
			c18 = new Card (Suit.DIAMONDS, Rank.SIX);
			c19 = new Card (Suit.HEARTS, Rank.SIX);
			c20 = new Card (Suit.SPADES, Rank.SIX);

			c21 = new Card (Suit.CLUBS, Rank.SEVEN);
			c22 = new Card (Suit.DIAMONDS, Rank.SEVEN);
			c23 = new Card (Suit.HEARTS, Rank.SEVEN);
			c24 = new Card (Suit.SPADES, Rank.SEVEN);

			c25 = new Card (Suit.CLUBS, Rank.EIGHT);
			c26 = new Card (Suit.DIAMONDS, Rank.EIGHT);
			c27 = new Card (Suit.HEARTS, Rank.EIGHT);
			c28 = new Card (Suit.SPADES, Rank.EIGHT);

			c29 = new Card (Suit.CLUBS, Rank.NINE);
			c30 = new Card (Suit.DIAMONDS, Rank.NINE);
			c31 = new Card (Suit.HEARTS, Rank.NINE);
			c32 = new Card (Suit.SPADES, Rank.NINE);

			c33 = new Card (Suit.CLUBS, Rank.TEN);
			c34 = new Card (Suit.DIAMONDS, Rank.TEN);
			c35 = new Card (Suit.HEARTS, Rank.TEN);
			c36 = new Card (Suit.SPADES, Rank.TEN);

			c37 = new Card (Suit.CLUBS, Rank.JACK);
			c38 = new Card (Suit.DIAMONDS, Rank.JACK);
			c39 = new Card (Suit.HEARTS, Rank.JACK);
			c40 = new Card (Suit.SPADES, Rank.JACK);

			c41 = new Card (Suit.CLUBS, Rank.QUEEN);
			c42 = new Card (Suit.DIAMONDS, Rank.QUEEN);
			c43 = new Card (Suit.HEARTS, Rank.QUEEN);
			c44 = new Card (Suit.SPADES, Rank.QUEEN);

			c45 = new Card (Suit.CLUBS, Rank.KING);
			c46 = new Card (Suit.DIAMONDS, Rank.KING);
			c47 = new Card (Suit.HEARTS, Rank.KING);
			c48 = new Card (Suit.SPADES, Rank.KING);

			c49 = new Card (Suit.CLUBS, Rank.ACE);
			c50 = new Card (Suit.DIAMONDS, Rank.ACE);
			c51 = new Card (Suit.HEARTS, Rank.ACE);
			c52 = new Card (Suit.SPADES, Rank.ACE);


			deck.AddCard (c1);
			deck.AddCard (c2);
			deck.AddCard (c3);
			deck.AddCard (c4);
			deck.AddCard (c5);
			deck.AddCard (c6);
			deck.AddCard (c7);
			deck.AddCard (c8);
			deck.AddCard (c9);
			deck.AddCard (c10);
			deck.AddCard (c11);
			deck.AddCard (c12);
			deck.AddCard (c13);
			deck.AddCard (c14);
			deck.AddCard (c15);
			deck.AddCard (c16);
			deck.AddCard (c17);
			deck.AddCard (c18);
			deck.AddCard (c19);
			deck.AddCard (c20);
			deck.AddCard (c21);
			deck.AddCard (c22);
			deck.AddCard (c23);
			deck.AddCard (c24);
			deck.AddCard (c25);
			deck.AddCard (c26);
			deck.AddCard (c27);
			deck.AddCard (c28);
			deck.AddCard (c29);
			deck.AddCard (c30);
			deck.AddCard (c31);
			deck.AddCard (c32);
			deck.AddCard (c33);
			deck.AddCard (c34);
			deck.AddCard (c35);
			deck.AddCard (c36);
			deck.AddCard (c37);
			deck.AddCard (c38);
			deck.AddCard (c39);
			deck.AddCard (c40);
			deck.AddCard (c41);
			deck.AddCard (c42);
			deck.AddCard (c43);
			deck.AddCard (c44);
			deck.AddCard (c45);
			deck.AddCard (c46);
			deck.AddCard (c47);
			deck.AddCard (c48);
			deck.AddCard (c49);
			deck.AddCard (c50);
			deck.AddCard (c51);
			deck.AddCard (c52);

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

