using System;


namespace myConsoleProject.cs
{
    internal class Program
    {
        static void Main()

        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            
            Console.WriteLine("Welcome to Acme Accounting Systems\nRemember, we're \"accounting\" on you!");
            Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            string favoriteNumber = Console.ReadLine();
            //  Console.WriteLine("Your favorite number is: " + favoriteNumber);
            int favoNum = Convert.ToInt32(favoriteNumber);
            int total = favoNum + 5;
            Console.WriteLine("Your favorite number plus 5 is: " + total);
            Console.ReadLine() ;
        }

    }
}
