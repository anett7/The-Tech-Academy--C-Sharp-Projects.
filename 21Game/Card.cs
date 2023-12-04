using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Game
{
    public struct Card
    {
        public Suit Suit { get; set; }
        public Face Face {get; set;)
            
        //every object, every class has a built in method as part of the .Net framework (ToString method)
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }

    }
    public enum Suit
    {
        Clubs,
        Diamond,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Ace,
        Jack,
        King,
        Queen
    }
}
