using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGolf
{
    class Player : Game

    {
        public string name;
        int score;

        public Player()
        {
           
        }

        public void SetPlayerName()
        {
            Console.WriteLine("enter your name:");
            Player player1 = new Player();
            player1.name = Console.ReadLine();
            Console.WriteLine(player1.name);
            Console.ReadKey();
        }

    }
}
