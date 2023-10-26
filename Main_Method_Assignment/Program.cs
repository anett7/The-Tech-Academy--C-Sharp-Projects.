using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class_method class
            class_method math1 = new class_method();
            //call the first method with an int parameter
            Console.WriteLine(math1.MathOperation(6));

            //call the second method with decimal parameter
            Console.WriteLine(math1.MathOperation(6.3m));
            //call the third method with a string parameter
            Console.WriteLine(math1.MathOperation("7"));
            Console.ReadLine();
        }
    }
    
}
