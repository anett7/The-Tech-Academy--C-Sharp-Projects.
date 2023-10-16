using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();
            //upon instanciating that object, it should have an entire deck of 52cards
            //deck object which has a property cards, that cards list should have 52 cards in it
            //to print it, we create an other foreach loop
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " +card.Suit);

            }

            //print out count to see it is 52:
            Console.WriteLine(deck.Cards.Count);

            //to fill up deck one by one START would be like this:

            //Deck deck = new Deck();
            //deck.Cards = new List<Card>();

            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";
            //deck.Cards.Add(cardOne);

            //fill up one by one END. Lets create a constractor instead.

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            Console.ReadLine();
        }
    }
}
