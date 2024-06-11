using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{


    internal class Swan : Bird
    {
        public bool UglyDuckling { get; set; }


        public override string Stats()
        {
            string swanStats = "Swan name is : " + AnimalName + ".\nSwan weighs " + AnimalWeight + " kgs and is " + AnimalAge + " years old.\nIt's " + UglyDuckling + " that what was thought to be an ugly duckling was in fact a swan!";
            return swanStats;
        }

    }
}
