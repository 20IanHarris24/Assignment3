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
            //UglyDuckling = true;
            string Swan = "It's "+ UglyDuckling +" that what was thought to be an ugly duckling was in fact a swan!";

            return Swan;
        }

    }
}
