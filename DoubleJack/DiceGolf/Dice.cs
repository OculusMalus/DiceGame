using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGolf
{
    class Dice
    {
        public int[] rollResult = new int[6];           //array to store six values, one from each of the six dice
        public int numberOfRollsToThreeOfAKind;
        public int roll;
        Random rnd = new Random();

        public void RollTwentySidedDice()
        {
            roll = rnd.Next(1, 21);
            Console.WriteLine("You rolled a {0}", roll);
            roll = rollResult[0];
        }

        public void RollTwelveSidedDice()
        {
            roll = rnd.Next(1, 13);
            Console.WriteLine("...and a {0}", roll);
            roll = rollResult[1];
        }

        public void RollTenSidedDice()
        {
            roll = rnd.Next(1, 11);
            Console.WriteLine("...and a {0}", roll);
            roll = rollResult[2];
        }

        public void RollEightSidedDice()
        {
            roll = rnd.Next(1, 9);
            Console.WriteLine("...and a {0}", roll);
            roll = rollResult[3];
        }

        public void RollSixSidedDice()
        {
            roll = rnd.Next(1, 7);
            Console.WriteLine("...and a {0}", roll);
            roll = rollResult[4];
        }

        public void RollFourSidedDice()
        {
            roll = rnd.Next(1, 5);
            Console.WriteLine("...and a {0}", roll);
            roll = rollResult[5];
        }



        //{
        //    roll 20 sided store at [0]
        //        roll 12 sided store at [1]
        //        roll 10 sided and so on...
        //        roll 8 sided
        //        roll 6 sided
        //        roll 4 sided
        //}

        //public bool checkRollResults()
        //{
        //    check for three of a kind

        //}
    }
}
