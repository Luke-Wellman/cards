using System;
using System.Collections.Generic;
using System.Linq;
namespace cards
{
    public class Deck
    {
        private Random random = new Random();
        public List<string> Suits = new List<string>{"Diamond","Heart","Spade","Club"};
        public List<string> Values = new List<string>{"2","3","4","5","6","7","8","9","10","Jack","Queen","King","Ace"};
        public Stack<Card> deck = new Stack<Card>();
        public void newDeck()
        {
            foreach (string suit in Suits)
            {
                foreach (string val in Values)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Value = val;
                    deck.Push(card);
                }
            }
            Console.WriteLine("\n!!New deck created!!\n");
        }
        public bool isEmpty()
        {
            if (deck.Count == 0)
            {
                Console.WriteLine("\nDeck is empty!");
                return true;
            }
            return false;
        }
        public void shuffle()
        {
            List<Card> list = deck.ToList(); 
            int n = list.Count;
            while(n>1)
            {
                n--;
                int randomItem  = random.Next(n+1);
                Card value = list[randomItem];
                list[randomItem] = list[n];
                list[n]= value;
            }
            deck = new Stack<Card>(list);
            Console.WriteLine("\nDeck Shuffled");
        }
        public void deal()
        {
            Console.WriteLine($"{deck.Peek().Value} of {deck.Peek().Suit}'s");
            deck.Pop();
        }
        public void dealerMenu()
        {
            Console.Clear();
            while(isEmpty() != true)
            {
                Console.WriteLine("ENTER to deal a new card | S to Shuffle | Q to Quit");
                switch (Console.ReadLine().ToLower())
                {
                    case "":
                        deal();
                        break;
                    case "s":
                        shuffle();
                        break;
                    case "q":
                        deck = new Stack<Card>();
                        break;
                    default:
                        break;
                }
                
            }
            
        }
    }
}