﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGolf
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.RunGame();
            Console.WriteLine("\nThank you for playing!");
            Console.ReadKey();      
         
        }
    }
}
