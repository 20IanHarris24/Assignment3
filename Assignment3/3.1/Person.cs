using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Person
    {
        //Field
        private int _age;
        private string _fName;
        private string _lName;
        private double _height;
        private double _weight;

        public Person(int age, string fName, string lName, double height, double weight)
        {
            _age = age;
            _fName = fName;
            _lName = lName;
            _height = height;
            _weight = weight;
        }

        public int Age //Property with input validation
        {    
            get { return _age; }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException($"The Age value entered: {value}, must be greater than 0 (zero)");
                }
                        else 
                        {
                        _age = value;                      
                        }
            }

        }

       
        public string FName //Property with input validation
        {    
            get { return _fName; }

            set 
            { 
                if (value.Length < 3 || value.Length > 10)
                {
                    throw new ArgumentException($"The first name entered contained: {value.Length} characters. The first name should contain between 2 and 10 characters");
                }
                        else 
                        {
                        _fName = value;
                        }
            }
        }

       

        public string LName //Property with input validation
        {     
            get { return _lName; }

            set 
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException($"The last name entered contained: {value.Length} characters. The last name should contain between 3 and 15 characters");
                }
                        else 
                        {
                        _lName = value;
                        }
            }
          }
         
            

        
            public double Height
            {
                get { return _height; }
                set { _height = value; }
            }
        

            public double Weight
            {
                get { return _weight; }
                set { _weight = value; }    
            }


       
    }


   





}
