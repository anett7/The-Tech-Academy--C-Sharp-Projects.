using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
     class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            _2intParameters math= new _2intParameters();
            //call the method in the class passing in 2 numbers
            //Console.WriteLine(math.Math2Int(6, 3));
            //call the method in the class specifying the parameters by name
            Console.WriteLine(math.Math2Int(num2: 3, num1: 6));
            Console.ReadLine();

        }
    }
}
