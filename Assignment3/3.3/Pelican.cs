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
            
            string Pelican = "A pelican can eat about " + EatFish + " large teeth";
            return Pelican;
        }


    }
}


