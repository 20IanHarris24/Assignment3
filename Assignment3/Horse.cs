using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Horse : Animal
    {
        public bool SleepStandingUp { get; set; }

        public override void DoSound() 
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The horse says: Neee Neeely Neee Neee");
        }



    }
}
