using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight?");

            int PackageWeight = Convert.ToInt32(Console.ReadLine());

            if (PackageWeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day!");
            }
            else if (PackageWeight==50)
            {
                Console.WriteLine("Please enter package width!");
            }

            else if (PackageWeight < 50)
            {
                Console.WriteLine("Please enter package width!");
            }

            //WIDTH, height, length

            int PackageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package height!");
             int PackageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package length!");
             int PackageLength = Convert.ToInt32(Console.ReadLine());

            int result = PackageWidth + PackageLength + PackageHeight;
            int quote = (PackageLength*PackageHeight*PackageWidth * PackageWeight) / 100;

            if (result > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express. Have a good day!");
                Console.ReadLine();

            }
            else if (result == 50)
            {
                Console.WriteLine("Your estimated total for shipping this package is:£" + quote + "Thank You!");
                Console.ReadLine();
            }

            else if (result < 50)
            {
                Console.WriteLine("Your estimated total for shipping this package is:£" + quote + "Thank You!");
                Console.ReadLine();
            }

           


        }
    }
}
