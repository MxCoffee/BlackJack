using System;
using System.Collections.Generic;

namespace BlackJack
{
	abstract class Hand
	{
		static List<Hand> hand = new List<Hand>();
		public Hand ()
		{
		}
		public void AddCard(Card card) //adds a card to this hand
		{
			hand.Add(card);
		}
	
		public bool ContainsCard(Card card) //returns true if the card is in this hand, false otherwise
		{
			if (hand.Contains(card)) 
			{
				return true;
			} 
			else 
			{
				return false;
			}
		}
		public void DiscardHand() //throws away all cards in the hand, leaving an empty hand
		{
			hand.Clear ();
		}
		public int FindCard(Card card) //searches the hand for the first occurence of the specified card and returns the index
		{
			return hand.IndexOf (card);
		}
		public Card GetCardAtIndex(int i) //obtains the card stored at the specified location in the hand
		{
			return hand (i);
		}
		public int GetNumberOfCards() //returns the number of cards in the hand
		{
			return hand.Count;
		}
		public bool IsEmpty() //returns true if the hand is empty, false otherwise
		{
			if (hand.Count == 0) 
			{
				return true;
			} 
			else 
			{
				return false;
			}
		}
		public Card RemoveCard(Card card) //removes the first occurence of the specified card from this hand
		{
			card.getName ();

		}
		public Card RemoveCard(int i) //removes the card at the specified index position from this hand
		{
			hand.RemoveAt(i);
		}

		override public string ToString() //a description of this hand, which includes all cards in the hand
		{
			string fullHand;
			foreach (Hand x in hand) 
			{
				fullHand += " " + x;
			}
			return fullHand;
		}

	}
}
