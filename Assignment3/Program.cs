using Assignment3;
using System;
using System.Data.Common;

internal class Program
{
    private static void Main(string[] args)
    {
        //Person person = new Person(); //Create an object of the Person class
        //Person person1 = new Person(37, "Terry", "Sunport", 1.75, 87.6); //Instansiating the object of the Person class
        //Person person2 = new Person(31, "Lily", "Turnington", 1.70, 77.5);  //Instansiating the object of the Person class

        
        PersonHandler personHandler = new PersonHandler(); //Create an object of PersonHandler class
        var personCreated1 = personHandler.CreatePerson(31,"Julia", "Turnpike", 178, 80.3); //Instansiate person object using PersonHandler class
        var personCreated2 = personHandler.CreatePerson(40,"Tina", "Johnson", 168, 79.5);   //Instansiate person object using PersonHandler class
        var personCreated3 = personHandler.CreatePerson(31, "Simon", "Smith", 169, 85.2);   //Instansiate person object using PersonHandler class
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\n\t Created Person: {personHandler.Getf_name(personCreated1)} {personHandler.Getl_name(personCreated1)}, Age: {personHandler.GetAge(personCreated1)}, Height: {personHandler.GetHeight(personCreated1)} cms, Weight: {personHandler.GetWeight(personCreated1)} kgs"); //Confirming person object attributes 
        Console.WriteLine($"\n\t Created Person: {personHandler.Getf_name(personCreated2)} {personHandler.Getl_name(personCreated2)}, Age: {personHandler.GetAge(personCreated2)}, Height: {personHandler.GetHeight(personCreated2)} cms, Weight: {personHandler.GetWeight(personCreated2)} kgs"); //Confirming person object attributes 
        Console.WriteLine($"\n\t Created Person: {personHandler.Getf_name(personCreated3)} {personHandler.Getl_name(personCreated3)}, Age: {personHandler.GetAge(personCreated3)}, Height: {personHandler.GetHeight(personCreated3)} cms, Weight: {personHandler.GetWeight(personCreated3)} kgs"); //Confirming person object attributes 

        personHandler.SetAge(personCreated2,35);  //Update Age for person 2
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\n\t Person: {personHandler.Getf_name(personCreated2)}, Updated Age: {personHandler.GetAge(personCreated2)}"); //Confirming Age change for person2 
        personHandler.PersonClapping(personHandler.Getf_name(personCreated2));  //Person 2 celebrates by clapping

        personHandler.SetHeight(personCreated1, 175);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\n\t Person: {personHandler.Getf_name(personCreated1)}, Updated Height: {personHandler.GetHeight(personCreated1)}"); //Confirming Height change for person1
        personHandler.PersonDancing(personHandler.Getf_name(personCreated1));  //Person 2 celebrates by dancing

        personHandler.Setl_name(personCreated3, "Smithson");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\n\t Person: {personHandler.Getf_name(personCreated3)}, Updated Last name: {personHandler.Getl_name(personCreated3)}"); //Confirming Last name change for person3
        personHandler.PersonSinging(personHandler.Getf_name(personCreated3));  //Person 3 celebrates by singing


        /*personCreated1.
        person.SetAge(person(), 37);
        person.CreatePerson(37, "Terry", "Sunport", 1.75, 87.6);
        string Firstname1 = person.FName;
        string Lastname1 = person.LName;
        int Age2 = person2.Age;
        string Firstname2 = person2.FName;
        string Lastname2 = person2.LName;
        Console.WriteLine($"\t First Name: {Firstname2}, Last Name: {Lastname2}, Age: {Age2} years old");*/



        //Testing the validation of the Person properties with Try catch


        /* try
          {
              //Console.WriteLine("\n\ttesting invalid inputs");
              //Console.WriteLine("\n\ttesting with ages");
              //person.Age = 0;
              //person.Age = -2;

              //Console.WriteLine("\n\ttesting with first names");
              //person!.FName = "T";
              //person!.FName = "Julia_Poolia_Coolia";

              //Console.WriteLine("\n\ttesting with last names");
              //person!.LName = "Sunport_lively_town";
              //person!.LName = "Tu";




          }
          catch (ArgumentException arg_ex)

          {
              //Console.ForegroundColor = ConsoleColor.Red;
              //Console.WriteLine(arg_ex.ToString());

          }*/


        // person2.FName = "Julianna";
        /* person2.Age = 32;
         Console.ForegroundColor = ConsoleColor.DarkYellow;
         Console.WriteLine($"\n\t Updated first Name: {person.FName}, Last Name: {person.LName}, Age: {person.Age} years old");
         Console.WriteLine($"\t Updated first Name: {person2.FName}, Last Name: {person.LName}, Age: {person2.Age} years old");*/

        Console.ResetColor();
    }

   
}