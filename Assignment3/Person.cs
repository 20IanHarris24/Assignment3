using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Person
    {
        private int _age;
        private string _fName;
        private string _lName;
        private double _height;
        private double _weight;


        public Person(string firstName, string lastName, int age, double height, double weight) ///Instance Constructor
        {
            _fName = firstName;
            _lName = lastName;
            _age = age;
            _height = height;
            _weight = weight;
        }

        public int GetAge() 
        {
            return _age;
        }

        public void SetAge(int age)
        {
           _age = age; 
        }


        public string GetFName()
        {
            return _fName;
        }

        public void SetFName(string fName)
        {
            _fName = fName;
        }

        public string GetLName()
        {
            return _lName;
        }

        public void SetLName(string lName)
        {
            _lName = lName;
        }

        public double GetHeight()
        {
            return _height;
        }

        public void SetHeight(double height)
        {
            _height = height;
        }

        public double GetWeight()
        {
            return _weight;
        }

        public void SetWeight(double weight)
        {
            _weight = weight;
        }




    }
    






   
}
