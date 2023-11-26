using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Game
{
    public abstract class Game
    {
        //game is capable to play with more than one player, that is why we created a list of 'Players'
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        // dictionary players and bets called Bets
        public Dictionary<Player, int> Bets { get; set; }
     
        public abstract void Play();
        public virtual void ListPlayers()
        {
            foreach ( Player player in Players )
            {
                Console.WriteLine(player.Name);
            }
            
        }
    }
}
