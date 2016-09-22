using System;
using System.Collections.Generic;

namespace BlackJack
{
	public class Deck
	{
		private  List<Card> deck = new List<Card>();
		private  List<Card> removed = new List<Card>();

		public Deck()
		{
		}
		public void AddCard(Card card) //adds a card to the deck
		{
			deck.Add (card);
		}
		public Card DealOne() //deal one card from the deck
		{
			Card x = deck [0];
			removed.Add (deck [0]);
			deck.RemoveAt (0);
			return x;
		}
		public int GetCardsRemaining() //returns the number of cards remaining in the current deck
		{
			return deck.Count;	
		}
		public int GetDeckSize() //returns the size of a full deck of cards
		{
			int x = deck.Count + removed.Count;
			return x;
		}
		public bool IsEmpty()  //returns true if the deck is empty
		{
			if (deck.Count == 0) 
			{
				return true;
			} else 
			{
				return false;
			}
		}
		public void Shuffle() //shuffles the deck of cards that are present in the deck
		{
			List<Card> shuffleDeck = new List<Card>();

			Random r = new Random();
			int randomIndex = 0;
			while (deck.Count > 0)
			{
				randomIndex = r.Next(0, deck.Count); //Choose a random object in the list
				shuffleDeck.Add(deck[randomIndex]); //add it to the new, random list
				deck.RemoveAt(randomIndex); //remove to avoid duplicates
			}
			foreach (Card x in shuffleDeck) 
			{
				deck.Add (x);
			}
		}
		public void RestoreDeck() //resets the deck back to a full deck, by replacing any cards that were dealt out
		{
			foreach (Card x in removed) 
			{
				deck.Add (x);
			}
			
		}
	}
}

