using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Contracts;

namespace Assignment3
{
    internal class Dog : Animal, IDog
    {
        public bool GoodHearing { get; set; }

        public override void DoSound()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The dog says: Woof Woofy Woof woof");
            Console.ResetColor();
        }

        public override string Stats()
        {
            //GoodHearing = true;
            string dogStats = "Dog name is : " + AnimalName + ".\nDog weighs " + AnimalWeight + " kgs and is " + AnimalAge + " years old.\nIt is "+ GoodHearing +" that dogs have exceptional hearing";
            return dogStats;
        }

        public string SleepingOnTheSofa()
        {
            string Sofa = "I am the worlds best at sleeping on the sofa";
            return Sofa;
        }

    }
}
