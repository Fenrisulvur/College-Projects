using System;
using System.Collections.Generic;

namespace BetMe
{

    public enum Suit
    {
        Spade,
        Heart,
        Club,
        Diamond,
    }

    public enum Number
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }

    public class Card
    {
        private Suit suit;
        private Number number;

        public Card(Suit suit, Number number)
        {
            this.suit = suit;
            this.number = number;
        }
    }

    public abstract class CardCollection
    {
        protected List cards = new List();

        public void AddCard(Card card) => cards.Add(card);

        public void RemoveCard(Card card)
        {
            if (cards.Contains(card) == true)
            {
                this.cards.Remove(card);
            }
            else
            {
                throw new InvalidOperationException("The card is not in the deck");
            }
        }
    }

    public class Hand : CardCollection
    {
    }

    public class Deck : CardCollection
    {
        public Deck()
        {
            foreach (Suit currentSuit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Number currentNumber in Enum.GetValues(typeof(Number)))
                {
                    AddCard(new Card(currentSuit, currentNumber));
                }
            }
        }
    }
}