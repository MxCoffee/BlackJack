using System;

namespace BlackJack
{
	class CardCountHand : Hand
	{
		public CardCountHand ()
		{
		}
		abstract int EvaluateHand() //evaluates the hand, returns an integer corresponding to the rating of the hand.
		{

		}
		abstract int CompareTo(Hand OtherHandObject) //compares two hands
		{


		}
	}
}

