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
        }




    }
}
