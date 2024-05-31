using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    abstract class Animal
    {


        public string? Name;
        public int Age;
        public double Weight;

        public Animal()
        {
                       
        }


        public string? AnimalName { get; set; }
        public int AnimalAge { get; set; }
        public double AnimalWeight { get; set; }

        public abstract void DoSound();

    }
}








    

