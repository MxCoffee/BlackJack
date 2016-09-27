using System;
using System.Collections.Generic;

namespace HW2
{
	public class Card
	{
		private Suit suit;
		private Rank rank;

		public Card (Suit suit, Rank rank)
		{
			this.suit = suit;
			this.rank = rank;
		}
		public int CompareTo(Card OtherCardObject)
		{
			if (this.suit.CompareTo(OtherCardObject.suit) == 0 && this.rank.CompareTo(OtherCardObject.rank) == 0) 
			{
				return 0;
			} 
			else if (this.rank.CompareTo(OtherCardObject.rank) == -1)
			{
				return -1;
			}
			else 
			{
				return 1;
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
			string result = rank.GetSymbol() + suit.GetSymbol();
			return result;
		}
	}
}

