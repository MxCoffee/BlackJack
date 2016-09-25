using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
	class BlackJackHand : Hand
	{
		
		public override int EvaluateHand() //evaluates the hand, returns an integer corresponding to the rating of the hand.
		{
			int rating = 0;
			foreach (Card x in hand) 
			{
				if(x.ToString().Contains("ACE"))
				{
					rating += 1;
				}
				if(x.ToString().Contains("TWO"))
				{
					rating += 2;
				}
				if(x.ToString().Contains("THREE"))
				{
					rating += 3;
				}
				if(x.ToString().Contains("FOUR"))
				{
					rating += 4;
				}
				if(x.ToString().Contains("FIVE"))
				{
					rating += 5;
				}
				if(x.ToString().Contains("SIX"))
				{
					rating += 6;
				}
				if(x.ToString().Contains("SEVEN"))
				{
					rating += 7;
				}
				if(x.ToString().Contains("EIGHT"))
				{
					rating += 8;
				}
				if(x.ToString().Contains("NINE"))
				{
					rating += 9;
				}
				if(x.ToString().Contains("TEN"))
				{
					rating += 10;
				}
				if(x.ToString().Contains("JACK"))
				{
					rating += 10;
				}
				if(x.ToString().Contains("QUEEN"))
				{
					rating += 10;
				}
				if(x.ToString().Contains("KING"))
				{
					rating += 10;
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
		public BlackJackHand ()
		{
			
		}

	}
}

