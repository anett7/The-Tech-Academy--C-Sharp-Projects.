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
            TwentyOneGame game = new TwentyOneGame();
            //instantiate with some values the players property inherited from Game object
            //there is access to all properties and methods of Game class
            game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //call method
            game.ListPlayers();
            game.Play();
            Console.ReadLine();
        }

        //    Deck deck = new Deck();
        //    //creating an optional parameter
        //    //get rid of this after method is paste in deck class:
        //    // deck = Shuffle(deck, 3);
        //    //we call this method 3 times on itself
        //    deck.Shuffle(3);

        //    //upon instantiating that object, it should have an entire deck of 52cards
        //    //deck object which has a property cards, that cards list should have 52 cards in it
        //    //to print it, we create an other foreach loop
        //    foreach (Card card in deck.Cards)
        //    {
        //        Console.WriteLine(card.Face + " of " + card.Suit);

        //    }

        //    //print out count to see it is 52:
        //    Console.WriteLine(deck.Cards.Count);
        //    Console.ReadLine();

        //    //to fill up deck one by one START would be like this:

        //    //Deck deck = new Deck();
        //    //deck.Cards = new List<Card>();

        //    //Card cardOne = new Card();
        //    //cardOne.Face = "Queen";
        //    //cardOne.Suit = "Spades";
        //    //deck.Cards.Add(cardOne);

        //    //fill up one by one END. Lets create a constractor instead.

        //    //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
        //    Console.ReadLine();
        //}

            //Cut and paste this shuffle method in deck class:
        //}
        //public static Deck Shuffle(Deck deck, int times = 1)
        //{

        //    for (int i = 0; i < times; i++)
        //    {
        //        List<Card> TempList = new List<Card>();
        //        Random random = new Random();
        //        while (deck.Cards.Count > 0)
        //        {
        //            int randomIndex = random.Next(0, deck.Cards.Count);
        //            TempList.Add(deck.Cards[randomIndex]);
        //            deck.Cards.RemoveAt(randomIndex);
        //        }
        //        deck.Cards = TempList;
        //    }

        //    return deck;
      //  }


        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for(int i=0; i< times;i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}

    }
}
