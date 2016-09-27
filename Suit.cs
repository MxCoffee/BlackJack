using System;
using System.Collections.Generic;

namespace HW2
{
	public class Suit
	{
		public static Suit CLUBS;
		public static Suit DIAMONDS;
		public static Suit HEARTS;
		public static Suit SPADES;
		public static List<Suit> VALUES = new List<Suit>();

		private string name;
		private string symbol;

		static Suit() //instantiate objects
		{
			CLUBS = new Suit ("CLUBS", "\u2663");	
			DIAMONDS = new Suit ("DIAMONDS", "\u2666");
			HEARTS = new Suit ("HEARTS", "\u2665");
			SPADES = new Suit ("SPADES", "\u2660");
			
		}

		public Suit (string name, string symbol)
		{
			this.name = name;
			this.symbol = symbol;
			VALUES.Add (this);
		}
		public int CompareTo(Suit OtherSuitObject)
		{
			if (VALUES.IndexOf (this) > VALUES.IndexOf (OtherSuitObject))
			{
				return 1;
			}
				
			else if(VALUES.IndexOf(this) < VALUES.IndexOf(OtherSuitObject))
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
			return symbol;
		}
	}
}

