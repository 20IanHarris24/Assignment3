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
            
            string birdStats = "Bird name is : " + AnimalName + ".\nBird weighs " + AnimalWeight + " kgs and is " + AnimalAge + " years old.\nBird wingspan " + WingSpan + "cms";
            return birdStats;
        }

    }
}
