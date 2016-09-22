using System;
using System.Collections.Generic;

namespace BlackJack
{
	abstract class Hand
	{
		private List<Hand> hand = new List<Hand>();
		public Hand ()
		{
		}
		public void AddCard(Card) //adds a card to this hand
		{}
		abstract int CompareTo(Hand OtherHandObject) //compares two hands
		{}
		public bool ContainsCard(Card) //returns true if the card is in this hand, false otherwise
		{}
		public void DiscardHand() //throws away all cards in the hand, leaving an empty hand
		{}
		public int FindCard(Card) //searches the hand for the first occurence of the specified card and returns the index
		{}
		public Card GetCardAtIndex(int) //obtains the card stored at the specified location in the hand
		{}
		public int GetNumberOfCards() //returns the number of cards in the hand
		{
			return hand.Count;
		}
		public bool IsEmpty() //returns true if the hand is empty, false otherwise
		{}
		public Card RemoveCard(Card) //removes the first occurence of the specified card from this hand
		{}
		public Card RemoveCard(int) //removes the card at the specified index position from this hand
		{}
		abstract int EvaluateHand() //evaluates the hand, returns an integer corresponding to the rating of the hand.
		{}
		public string ToString() //a description of this hand, which includes all cards in the hand
		{}
	}
}

