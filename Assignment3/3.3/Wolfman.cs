using Assignment3.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Wolfman : Wolf, IPerson
    {
        public void Talk()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cause this is thriller, thriller night\nAnd no one's gonna save you from the beast about to strike\nYou know it's thriller, thriller night\nYou're fighting for your life inside a killer, thriller tonight");
            Console.ResetColor();
        }


        public override string Stats()
        {
            string wolfmanStats = "Wolfman name is : " + AnimalName + ".\nWolfman weighs " + AnimalWeight + " kgs and is " + AnimalAge + " years old.\nA Wolfman likes to be out during a full moon";
            return wolfmanStats;
        }

    }
}
