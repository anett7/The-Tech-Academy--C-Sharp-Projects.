using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Game
    {
        //all games have a list of players, so that is a property common to all games:
        //prop tab tab:
        public List<string> Players { get; set; }
        // game name is also an other common property:
        public string Name { get; set; }
        //dealer:
        public string Dealer { get; set; }
        //we also need a method to print all players to the console when called:
        public void ListPlayers()
        {
            foreach ( string player in Players)
            {
                Console.WriteLine(player);
            }

        }
    }
    
}
