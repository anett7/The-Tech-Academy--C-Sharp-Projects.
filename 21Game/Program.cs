using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Game
{
     class Program
    {
        static void Main(string[] args)

            //Main method is entrance point of console application
        {   
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name");
            //receiving their name
            string playerName= Console.ReadLine();
            // how much money ready to spend, there is no set amount here
            Console.WriteLine("And how much money did you bring today");
            //take their answer
            int bank= Convert.ToInt32(Console.ReadLine());
            //we use string formatting and put a place holder in curly braces.playerName will be inserted 
            //in the string
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now", playerName);
            //we will check their answer and lower it to make it easier check against.
            string answer= Console.ReadLine().ToLower();
            if (answer == "yes" || answer=="yeah" || answer=="y" || answer=="ya")
            {
                //creating a new player object initalise him with his name and how much he brought,
                //this will be a constractor, immediatly instantiated
                Player player = new Player(playerName, bank);
                //create a game, polymorphism is happening here. _21Game but also Game, so that it exposes
                // those overloaded operaters we made
                Game game = new _21Game();
                //adding player to the game
                game += player;
                //we set this to true, because we create a while loop, keeping the player in the game
                //as long as he wants to. This property is constantly checked
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    //we want to see everything under our Play method, we create it and define later
                    game.Play();
                }

            }
        }
    }
}
