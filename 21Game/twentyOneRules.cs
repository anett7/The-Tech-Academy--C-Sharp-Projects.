using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Game
{
    public class twentyOneRules
    {
        //it will be used only by this class, so we mark it as private. 
        //static cause we don't want to create a 21rules object in order to access it. These are just 
        //basic helper methods that we are calling to perform some logic. 
        // key is the face as values are on the base of face
        //we create a new dictionary and we instantiate it with all of our objects. 
        // this dictionary of cards won't change, rules are set for a long while, we can add a value and it
        //won't change

        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            //dictionary entries one for each face to look up what  the value of a card is
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1

        };

        //get all possible hand values, it returns integerarray of the possible values
        {
        // 2cards with one ace has 2 poss.values( where ace equals 1 and where equals 11. If you have a hand of 3 cards with 2 aces, then there are 3 different values ( one where both equals 1, one equals one other 11, both equals 11)This last is a bast.
        // each item in hand we check if face is ace and it return count.
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
        //creating an array:
            int() result = new int[aceCount + 1];
        //getting the value of the hand with ace =1 with lambda expression. Take the card, look up its value and sum
            int value = Hand.Sum(x => _cardValues[x.Face]);
        //take the very first entry in our int.array and assign value to it
            result[0]=value;
            //no aces, then hand can only have one value, quick check:
            if (result.Length == 1 )return result;
            for (int i =1; i< result.Length; i++)
            {
            value= value +(i*10);
            result[i]=value
               }

        //does this contain an ace and a face card?
        public static bool CheckForBlackJack(List<Card> Hand)
        {

        }
    }
}
