using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{



    internal class Flamingo : Bird
    {
        public int EatShrimps { get; set; }



        public override string Stats()
        {
            EatShrimps = 60;
            string flamingoStats = "Flamingo name is : " + AnimalName + ".\nFlamingo weighs " + AnimalWeight + " kgs and is " + AnimalAge + " years old.\nFlamingoes eat about " + EatShrimps + "g of shrimp daily";
            return flamingoStats;
        }
    }
}
