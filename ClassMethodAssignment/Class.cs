using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public class Class
    {
        //create a class, a method, that outputs an integer. 
        public int MathDivide(int num1)
        {
            return num1 / 2;

        }
        //create method with output parameterds
        
        public string StringCounter(string input, out int count)
        {
            count = input.Length;
            string phrase = "your string is " + count + " characters long";
            return phrase;
        }
        
       //  overload previous method:

        public int StringCounter(string input)
        {
            int count = input.Length;
            return count;

        }
      
    }
}
