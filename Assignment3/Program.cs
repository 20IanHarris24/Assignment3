using Assignment3;
using System;
using System.Data.Common;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person("Terry", "Sunport", 37, 1.75, 87.6);
        //Person person2 = new Person("Julia", "Turnpike", 31, 1.78, 80.3);

        PersonHandler personNew = new PersonHandler();
        personNew.SetAge(person, 44);




       


        

        //person.SetAge(person(), 37);
        //person.CreatePerson(37, "Terry", "Sunport", 1.75, 87.6);
        /*string Firstname1 = person.FName;
        string Lastname1 = person.LName;
        int Age2 = person2.Age;
        string Firstname2 = person2.FName;
        string Lastname2 = person2.LName;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"\n\t First Name: {Firstname1}, Last Name: {Lastname1}, Age: {Age1} years old");
        Console.WriteLine($"\t First Name: {Firstname2}, Last Name: {Lastname2}, Age: {Age2} years old");



        Console.ResetColor();
*/
       

       /* try
        {
            Console.WriteLine("\n\ttesting invalid inputs");
            
            //updating with invalid ages
            //person.Age = 0;
            //person2.Age = -2;

            //updating with invalid first names
            //person.FName = "T";
            //person2.FName = "JuliaPoolia";

            //updating with invalid last names

            //person.LName = "Sunportlivelytown";
            //person.LName = "Tu";




        }
        catch (ArgumentException argex)

        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(argex.ToString());
            
        }*/
        
        
      //  person2.FName = "Julianna";
       /* person2.Age = 32;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"\n\t Updated first Name: {person.FName}, Last Name: {person.LName}, Age: {person.Age} years old");
        Console.WriteLine($"\t Updated first Name: {person2.FName}, Last Name: {person.LName}, Age: {person2.Age} years old");*/

       // Console.ResetColor();
    }
}