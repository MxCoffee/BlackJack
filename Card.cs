using System;
using System.Collections.Generic;

namespace BlackJack
{
	public class Card
	{
		public static List<Card> VALUES = new List<Card>();
		private Suit suit;
		private Rank rank;

		public Card (Suit suit, Rank rank)
		{
			this.suit = suit;
			this.rank = rank;
			VALUES.Add (this);
		}
		public int CompareTo(Card OtherCardObject)
		{
			if (VALUES.IndexOf(this) > VALUES.IndexOf(OtherCardObject)) 
			{
				return -1;
			} 
			else if (VALUES.IndexOf(this) > VALUES.IndexOf(OtherCardObject)) 
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}
		public Rank GetRank()
		{
			return rank;
		}
		public Suit GetSuit()
		{
			return suit;
		}
		override public string ToString()
		{
			string result = rank.GetName() + " of " + suit.GetName();
			return result;
		}
	}
}

