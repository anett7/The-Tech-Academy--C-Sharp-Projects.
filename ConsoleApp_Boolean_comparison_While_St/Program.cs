using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Boolean_comparison_While_St
{
    internal class Program
    {
        static void Main(string[] args)
        {//SWITCH STATEMENT
            //Console.WriteLine("Guess a number!");
            //int number = Convert.ToInt32(Console.ReadLine());
            //switch(number) 
            //{
            //    case 62:
            //        Console.WriteLine("You guessed 62. Try again.");
            //        break;
            //    case 29:
            //        Console.WriteLine("You guessed 29. Try again.");
            //        break;
            //    case 53:
            //        Console.WriteLine("You guessed 53. Try again.");
            //        break;
            //    case 12:
            //        Console.WriteLine("You guessed the number 12. That is correct!");
            //        break;
            //    default: 
            //        Console.WriteLine("You are wrong");
            //        break;
            //}
            //Console.ReadLine();

            //LOOP

            Console.WriteLine("Guess a number!");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;
            //insert do so that if 12 is guessed first the while loop is done at least once
            do
            {
                switch (number)
                {


                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 53:
                        Console.WriteLine("You guessed 53. Try again.");
                        Console.WriteLine("Guess a number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong");
                        Console.WriteLine("Guess a number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
             while (!isGuessed);
            
               
               
       
            Console.ReadLine();
        }
    }
}
