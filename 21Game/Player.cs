using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Game
{
    public class Player
    {
        //constructor, takes 2 parameters and assign some values to these
        public Player(string name, int beginningBalance)
        {
            //create an empty list card, we need to initalise list, otherwise we can't add things to them           
            Hand = new List<Card>();
            //we assign balance
            Balance = beginningBalance;
            //we assign name
            Name = name;
        }//we created a constructor that takes 2 arguments, we are taking those arguments and we assinging them
        //to properties in the class
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        //this is a property very specific to 21Game, better to create a 21Player class that inherit from Player class
        //we keep this inside of Player class for now:
        public bool Stay { get; set; }
        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            retrun game;
        }
        public static Game operator -(Game game, Player player)
            {
            game.Players.Remove(player);
            return Game;
            }
    }
}
