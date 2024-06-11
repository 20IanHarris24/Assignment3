using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Contracts;

namespace Assignment3
{
    internal class Wolf : Animal
    {
        public int LargeTeeth {  get; set; }
            
            public override void DoSound()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The wolf says: Growl Growly Growl Growl");
            Console.ResetColor();
        }

                
        public override string Stats()
        {
            string wolfStats = "Wolf name is : " + AnimalName + ".\nWolf weighs " + AnimalWeight + " kgs and is " + AnimalAge + " years old.\nA wolf has " + LargeTeeth + " large teeth";
            return wolfStats;
        }
    }

  
}
