using System;
using System.Collections.Generic;

namespace BlackJack
{
	public class Rank
	{
		public static Rank TWO;
		public static Rank THREE;
		public static Rank FOUR;
		public static Rank FIVE;
		public static Rank SIX;
		public static Rank SEVEN;
		public static Rank EIGHT;
		public static Rank NINE;
		public static Rank TEN;
		public static Rank JACK;
		public static Rank QUEEN;
		public static Rank KING;
		public static Rank ACE;
		public static List<Rank> VALUES = new List<Rank>();//holds rank objects

		private string name;
		private string symbol;

		static Rank()//instantiate objects
		{
			TWO = new Rank ("TWO", "2");	
			THREE = new Rank ("THREE", "3");
			FOUR = new Rank ("FOUR", "4");
			FIVE = new Rank ("FIVE", "5");
			SIX = new Rank ("SIX", "6");
			SEVEN = new Rank ("SEVEN", "7");
			EIGHT = new Rank ("EIGHT", "8");
			NINE = new Rank ("NINE", "9");
			TEN = new Rank ("TEN", "10");
			JACK = new Rank ("JACK", "J");
			QUEEN = new Rank ("QUEEN", "Q");
			KING = new Rank ("KING", "K");
			ACE = new Rank ("ACE", "A");

		}

		public Rank(string name, string symbol)
		{
			this.name = name;
			this.symbol = symbol;
			VALUES.Add(this);
		}

		public int CompareTo(Rank OtherRankObject)
		{
			if (VALUES.IndexOf (this) > VALUES.IndexOf (OtherRankObject)) 
			{
				return 1;
			}
			else if(VALUES.IndexOf(this) < VALUES.IndexOf(OtherRankObject))
			{
				return -1;
			}
			else 
			{
				return 0;
			}
		}
		public string GetSymbol()//the symbol associated with the rank
		{
			return symbol;
		}
		public string GetName()//the name associated with the rank
		{
			return name;
		}
		override public string ToString()//the name associated with the rank
		{
			return name;
		}
	}
}

