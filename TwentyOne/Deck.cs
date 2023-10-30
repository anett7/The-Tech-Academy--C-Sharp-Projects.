using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        //I. Constructor
        public Deck() 
        {
            Cards = new List<Card>();
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);
            //this is not the best solution to add one by one. 

            //nested foreach loop:
            //create two list and instantiate them with values Each of these items in the faces list
            //we loop through 4 times. During each loop we create a card and assign the suit and face value
            //then we add that new card we created in the our cards List.
            List<string>Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades"};

            List<string> Faces = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven",
                                                    "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"};
            //loop through both of these lists in order to generate a deck of 52 cards
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    //add this card to the list as above Cards = new List<Card>();
                    Cards.Add(card);
                    //once this loop ends it does not exist anymore that is why we can create it over and
                    // over again with the same name.
                }
            }

        }
        //II.Property
        public List<Card> Cards { get; set; }

        //III.Shuffle method ( pasting method from program into this class):

        //static:you can call this method without applying to this specific deck created
        //delete static so that this method belongs to this object created.
        //this method takes only one parameter, times.
        public void Shuffle( int times = 1)
        {

            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();
                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }

           
        }
    }
}
