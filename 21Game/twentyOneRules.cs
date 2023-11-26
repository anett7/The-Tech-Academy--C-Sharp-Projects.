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

        };
    }
}
