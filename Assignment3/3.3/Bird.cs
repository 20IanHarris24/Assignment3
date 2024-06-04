using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Bird : Animal
    {
        public int WingSpan { get; set; }

        public override void DoSound()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The bird says: Chirp Chirpy Chirp Chirp");
            Console.ResetColor();
        }

        public override string Stats()
        {
            //WingSpan = 65;
            string Bird = "Bird wingspan " + WingSpan + "cms";

            return Bird;
        }

    }
}
