using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Worm : Animal
    {
        public bool BilaterallySymmetrical { get; set; }


        public override void DoSound()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The worm says: Shuffle Shuffly Shuffle shuffle");
            Console.ResetColor();
        }

        public override string Stats()
        {
            //BilaterallySymmetrical = true;
            string wormStats = "worm name is : " + AnimalName + ".\nWorm weighs " + AnimalWeight + " kgs and is " + AnimalAge + " years old.\nIt is " + BilaterallySymmetrical + " that worms can be defined as BilaterallySymmetrical";
            return wormStats;
        }


    }
}
