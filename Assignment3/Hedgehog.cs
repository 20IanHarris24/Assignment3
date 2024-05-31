using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Hedgehog : Animal
    {
        public int NrOfSpines { get; set; }


        public override void DoSound()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The hedgehog says: Sniffle Sniffly Sniffle Sniffle");
        }



    }
}
