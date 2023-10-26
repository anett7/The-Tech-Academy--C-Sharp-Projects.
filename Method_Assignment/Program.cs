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
            //call the method passing in 2 numbers
            Console.WriteLine(math.Math2Int(6, 3));
            Console.ReadLine();

        }
    }
}
