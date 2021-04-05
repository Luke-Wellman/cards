using System;
using System.Collections.Generic;

namespace cards
{
    public class Deck
    {
        public List<string> Suits = new List<string>{"Diamond","Heart","Spade","Club"};
        public List<string> Values = new List<string>{"2","3","4","5","6","7","8","9","10","Jack","Queen","King","Ace"};
        public List<Card> deck = new List<Card>();

        public void newDeck()
        {
            foreach (string suit in Suits)
            {
                foreach (string val in Values)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Value = val;
                    deck.Add(card);
                }
            }
            foreach (var item in deck)
            {
                Console.WriteLine($"{item.Value} of {item.Suit}'s");
            }
        }

        public void isEmpty()
        {
            
        }

        public void shuffle()
        {

        }

        public void deal()
        {

        }       
    }
}