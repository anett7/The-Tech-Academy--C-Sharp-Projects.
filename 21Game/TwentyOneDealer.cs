using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Game
{
    public class TwentyOneDealer : Dealer
    {
        //dealer is dealt a hand also
        public List<Card> Hand { get; set; }
        // having a certain amount of cards, you feel you are close enough to 21 you can stay
        // you dont want to risk taking an other card and going over 21, cause then you bast
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
        //there are specific rules to the dealer if it is 16 or below, the dealer has to hit.
        //If 17, then the dealer has to stay. These will be built in an other class
    }
}
