using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{


    internal class Pelican : Bird
    {
        public double EatFish { get; set; }


        public override string Stats()
        {
            string pelicanStats = "Pelican name is : " + AnimalName + ".\nPelican weighs " + AnimalWeight + " kgs and is " + AnimalAge + " years old.\nA pelican can eat about " + EatFish + " kgs of fish a day";
            return pelicanStats;
        }


    }
}


