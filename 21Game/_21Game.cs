using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Game
{
    public class _21Game : Game, IWalkAway
    {
        //dealer is specific to the 21Game, therfore we have this dealer property
        public TwentyOneDealer Dealer { get; set; }

        //implementing play method, it is an override method, an abstract method in game class, which means
        //we have to have an implementation of it
        public override void Play()
        {
            //when we start game.play in Program class, we already have a game going and we instantiate
            //that dealer object as a new 21 dealer
            Dealer = new TwentyOneDealer();

            //since we are in a while loop, we are not sure at what stage we are at. We want to reset
            //all the players. game.Play is going to play one hand and the while loop goes through in program class
            //then an other hand, as long as the player says, that he is actively playing and balance is not zero

            //Reset the player. When we perform an action on a player, we actually want to do that on all the players
            //as in Game class we have a list of players not just one
            foreach (Player player in Players)
            {
                //reset player's hand to blank at each round
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            //Dealer's hand needs to be a new hand
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            //create a new deck, we dont want a partial deck to carry over
            Dealer.Deck = new Deck();

            //we called the play method, we created a new dealer, we looped through the players we reset them
            //we reset them with an empty hand and reset their stay to false. Same with the dealer. 
            //console writeline to instruct player to place bet:

            Console.WriteLine("Place your bet!");
            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                //if player has enough, this will be true
                bool successfullyBet = player.Bet(bet);
                // shorthand for: if (successfullyBet == false) ;
                if (!successfullyBet)
                {
                    //this is a void method we don't return anything just say with return to end this method, 
                    //this method will hover, going back to the while loop in program is actively playing
                    //balance is greater then zero so it will hit play method on top again, and says 'place your bet'
                    return;

                    //if successfullyBet fails we end the method if true nothing else will be hit, so we dont need to put an else 
                    //just continue with our code.

                    //we create a dictionary object for the bets to look up name and value, this in the game class

                }
                //we add player name and the bet to the dictionary
                Bets[player] = bet;
            }
            // next step to deal everyone 2 cards.
            //we loop for the players and give them a card and do that twice. A foreach loop inside of a foor loop. 
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing..")
                    //we loop through the players
                foreach (Player player in Players)
                {
                        //we write sg.to console, but don't press enter, so next things that comes won't be
                        //on a new line
                    Console.Write({ 0}; "player.Name");
                        //we are passing in the player's hand and its given a card and it is printed to the console
                        //so that you can see. Everyone can see everyone's card. The dealer to follow specific rules.
                        // It is no disadvantage if dealer sees your card in blackjack.
                    Dealer.Deal(player.Hand);
                        //by the second card we need to check for blackjack. ( if you are dealt an ace and a face card
                        //you win 1.5 of your bet immediately. 
                    if (i == 1)
                    {
                        //we need to know the value of each cards as well, that will be a whole set of method separate
                        //we were checking for blackjack
                        bool blackJack = twentyOneRules.CheckForBlackJack(palyer.Hand);
                        if (blackJack)
                        {
                         Console.WriteLine("Blackjack! { 0} wins { 1}", player.Name, Bets[player]);
                            //we give him his bet back (cause we took it from him) plus your bet 1.5 times.
                         player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            //we end the round here, once someone wins blackjack
                         return;
                        }

                    }

                }
                Console.Write("Dealer:");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = twentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if(blackjack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach (KeyValuePair < Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                    }
                 }
        
            
    }


}
