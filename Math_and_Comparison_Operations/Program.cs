using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_Comparison_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined= total+ otherTotal;
            //Console.WriteLine("combined total = " + combined.ToString());
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("ten-five=" + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();
            //there is no remainder showing as 0
            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();
            // here there is a remainder of 1

            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString()); 
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemp = 70;
            //bool isWarm = currentTemp != roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();


            //assignment Math and Comparison Operations to ask for input from user, perform operations and return value

            Console.WriteLine("What is your favorite number?");
            string favoriteNumber = Console.ReadLine();
            int favNum = Convert.ToInt32(favoriteNumber);
            int total = favNum * 50;
            Console.WriteLine("your favorite number multiplies by 50 is: " + total);
            Console.ReadLine();

            Console.WriteLine("Tell me an other number?");
            string otherNumber = Console.ReadLine();
            int otherNum = Convert.ToInt32(otherNumber);
            int totalplus = otherNum + 25;
            Console.WriteLine("your favorite number plus 25 is: " + totalplus);
            Console.ReadLine();

            Console.WriteLine("Tell me your next number?");
            string favoritNumber = Console.ReadLine();
            int favNumb = Convert.ToInt32(favoritNumber);
            double total2 = favNumb / 12.5;
            Console.WriteLine("your number devided by 12.5 is: " + total2);
            Console.ReadLine();


            Console.WriteLine("Tell me again a number?");
            string greaterNumber = Console.ReadLine();
            int greatNumb = Convert.ToInt32(greaterNumber);
            bool isGreaterOr= greatNumb > 50;
            Console.WriteLine("your number greater than 50 is: " + isGreaterOr);
            Console.ReadLine();

            Console.WriteLine("Tell me your last number?");
            string lastNumber = Console.ReadLine();
            int lastNumb = Convert.ToInt32(lastNumber);
            int divNum = lastNumb % 7;
            Console.WriteLine("The remainder is if your number is devided by 7: " + divNum);
            Console.ReadLine();



        }


    }
}
