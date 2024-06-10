using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class PersonHandler
    {


        public Person CreatePerson(int age, string f_name, string l_name, double height, double weight)
        { 
            Person personCreated = new Person(age, f_name, l_name, height, weight);
            return personCreated;
        }
        

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public int GetAge(Person pers)
        {
            return pers.Age;
        }

        public void Setf_name(Person pers, string f_name)
        {
            pers.FName = f_name;
        }

        public string Getf_name(Person pers)
        {
            return pers.FName;
        }

        public void Setl_name(Person pers, string l_name)
        {
            pers.LName = l_name;
        }

        public string Getl_name(Person pers)
        {
            return pers.LName;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public double GetHeight(Person pers)
        {
            return pers.Height;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public double GetWeight(Person pers)
        {
            return pers.Weight;
        }



        public void GetPerson()
        {
            //get the person objects?
        
        }


        public void DeletePerson()
        {
            //do something..
        }

        public void PersonClapping(string f_name)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n\t {f_name} is clapping");
        }

        public void PersonDancing(string f_name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\t {f_name} has moves like Jagger");
        }
        public void PersonSinging(string f_name)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"\n\t {f_name} is singing from the roof tops");
        }


    }
}
