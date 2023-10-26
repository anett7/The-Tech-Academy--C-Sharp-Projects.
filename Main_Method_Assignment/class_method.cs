using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    public class class_method
    {
        //first method that takes in an integer
        public int MathOperation(int number)
        {
            return number *2 ; 
        }

        //second method that takes in decimal
        public int MathOperation(decimal number)
        {
            //convert decimal to an int to perform math operation
            int dec_num= Convert.ToInt32(number);
            return dec_num + 3;
        }
        
        //third method that takes a string
        public int MathOperation(string number) 
        {
            //convert string to int to perform math operation
            int string_number = Convert.ToInt32(number);
            return string_number + 1;

        }
        
        
    }
}
