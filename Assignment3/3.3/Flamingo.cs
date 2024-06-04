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
            //EatShrimps = 60;
            string Flamingo = "Flamingoes eat about " + EatShrimps + "g of shrimp daily";

            return Flamingo;
        }
    }
}
