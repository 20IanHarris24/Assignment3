using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Dog : Animal
    {
        public bool GoodHearing { get; set; }


        public override void DoSound()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The dog says: Woof Woofy Woof woof");
        }

    }
}
