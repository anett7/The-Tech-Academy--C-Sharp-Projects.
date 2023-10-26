using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMathWithUserParamether
{
    public class MathMethod2Int
    {
        //create a method that takes two integers as parameters. Make one of them optional.
        // have the method do a math operation and return an integer result.
        public int Math2Int (int number1,  int number2 =2) 
        {
            //perform multiplication on integers and return result
            return number1 * number2; 
        }
    }
}
