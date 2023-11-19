using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Game
{
    public class _21Game :Game, IWalkAway
    {
        //dealer is specific to the 21Game, therfore we have this dealer property
        public TwentyOneDealer Dealer { get; set; }

        //implementing play method, it is an override method, an abstract method in game class, which means
        //we have to have an implementation of it
        public override void Play()
        {
            //when we start game.play in Program class, we already have a game going and we instantiate
            //that dealer object as a new 21 dealer
            Dealer =new TwentyOneDealer();
            
            //since we are in a while loop, we are not sure at what stage we are at. We want to reset
            //all the players. game.Play is going to play one hand and the while loop goes through in program class
            //then an other hand, as long as the player says, that he is actively playing and balance is not zero

            //Reset the player. When we perform an action on a player, we actually want to do that on all the players
            //as in Game class we have a list of players not just one
            foreach(Player player in Players)
        }
            
    }//we need to instantiate our dealer


}
