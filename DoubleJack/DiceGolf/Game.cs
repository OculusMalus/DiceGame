using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGolf
{
    class Game
    {

        public Player player1;
        public Player player2;
        public Dice dice;
        public bool rollAgain;
        public bool isGameOver;
        public int hole;
        

        public Game()
        {
        }

        public void RunGame()
        {
            SetUpNewGame();
            Dice dice = new Dice();
            dice.RollTwentySidedDice();
            dice.RollTwelveSidedDice();
            dice.RollTenSidedDice();
            dice.RollEightSidedDice();
            dice.RollSixSidedDice();
            dice.RollFourSidedDice();
        }

        private void SetUpNewGame()
        {
            Console.WriteLine("Welcome to Dice Golf, a game of chance that requires no skill whatsoever!");
            Console.WriteLine("Player 1, please enter your name:\n");
            Player player1 = new Player();
            player1.name = Console.ReadLine();

            Console.WriteLine("Player 2, please enter your name:\n");
            Player player2 = new Player(); 
            player2.name = Console.ReadLine();
            //dice.FirstRoll();            //calling a function in the Dice class that gives the first roll of the dice
            //not yet functioning

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();


        }
    }
}
