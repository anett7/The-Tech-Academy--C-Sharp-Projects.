using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //in the main method instantiate that class
            Class MathDev = new Class();

            //Have the user enter a number.
            Console.WriteLine("Please write a number between 1 and 100! ");
            int num1= Convert.ToInt32(Console.ReadLine());


            //Call the method on that number and display the output to the screen
            Console.WriteLine(" your number divided by 2 is: " + MathDev.MathDivide(num1));

            // method with output parameters
            Console.WriteLine("Input a phrase!");
            string input= Console.ReadLine();
            //calling method:
            Console.WriteLine(MathDev.StringCounter(input, out int count));

            // overload method
            Console.WriteLine("Input another phrase!");
            string input2 = Console.ReadLine();
            //calling overload method
            Console.WriteLine(MathDev.StringCounter(input2));

            //call method of static class
            StaticClass.StaticMethod();

            Console.ReadLine();
        }
    }
}
