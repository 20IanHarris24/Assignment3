using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Wolfman : Wolf
    {
        public void Talk()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\tCause this is thriller, thriller night\n\tAnd no one's gonna save you from the beast about to strike\n\tYou know it's thriller, thriller night\n\tYou're fighting for your life inside a killer, thriller tonight");

        }

    }
}
