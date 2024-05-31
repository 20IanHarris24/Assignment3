using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Wolf : Animal
    {
        public int LargeTeeth {  get; set; }
            
            public override void DoSound()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The wolf says: Growl Growly Growl Growl");
        }



    }
}
