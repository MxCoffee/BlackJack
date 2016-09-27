using System;
using System.Collections.Generic;
using System.Linq;

namespace HW2
{
	class BlackJackHand : Hand
	{
		public BlackJackHand ()
		{

		}
		
		public override int EvaluateHand() //evaluates the hand, returns an integer corresponding to the rating of the hand.
		{
			int rating = 0;
			foreach (Card x in hand) 
			{
				
				if(x.GetRank().GetSymbol() == "2")
				{
					rating += 2;
				}
				if(x.GetRank().GetSymbol() == "3")
				{
					rating += 3;
				}
				if(x.GetRank().GetSymbol() == "4")
				{
					rating += 4;
				}
				if(x.GetRank().GetSymbol() == "5")
				{
					rating += 5;
				}
				if(x.GetRank().GetSymbol() == "6")
				{
					rating += 6;
				}
				if(x.GetRank().GetSymbol() == "7")
				{
					rating += 7;
				}
				if(x.GetRank().GetSymbol() == "8")
				{
					rating += 8;
				}
				if(x.GetRank().GetSymbol() == "9")
				{
					rating += 9;
				}
				if(x.GetRank().GetSymbol() == "10")
				{
					rating += 10;
				}
				if(x.GetRank().GetSymbol() == "J")
				{
					rating += 10;
				}
				if(x.GetRank().GetSymbol() == "Q")
				{
					rating += 10;
				}
				if(x.GetRank().GetSymbol() == "K")
				{
					rating += 10;
				}
				if(x.GetRank().GetSymbol() == "A")
				{
					rating += 11;
				}
			}	
			return rating;
		}
		public override int CompareTo(Hand OtherHandObject) //compares two hands
		{
			if (this.EvaluateHand () > OtherHandObject.EvaluateHand ()) {
				return 1;
			}
			else if (this.EvaluateHand () < OtherHandObject.EvaluateHand ()) {

				return -1;
			}
			else
			{
				return 0;
			}
		}


	}
}

