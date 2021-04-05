using System;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.newDeck();
            deck.shuffle();
            while(deck.isEmpty() != true)
            {
                deck.deal();
            }   
        }
    }
}
