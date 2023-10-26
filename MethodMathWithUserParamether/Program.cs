using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMathWithUserParamether
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            while (counter < 5)
            {
                //instantiate the class
                MathMethod2Int math1 = new MathMethod2Int();
                // ask the user to provide first parameter
                Console.WriteLine("Please write your first number between 1 and 10!");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Add your second number or just press enter!");
                try
                {
                    //call method with 2 parameters if both provided

                    int number2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("to multiply these two numbers, the result is: " + math1.Math2Int(number1, number2));
                    Console.ReadLine();
                }
                catch
                {
                    //call method with one parameter 

                    Console.WriteLine(" to multiply your number with default number 2 is: " + math1.Math2Int(number1));
                    Console.ReadLine();
                }
                counter++;
            }
        }
    }
}
