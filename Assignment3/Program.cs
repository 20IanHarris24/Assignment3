﻿using Assignment3;
using System;
using System.Data.Common;

internal class Program
{
       
    

    private static void Main(string[] args)

        
    {

        //Assignment 3 Section 3.1 ENCAPSULATION

        /*
        Person person = new Person(); //Create an empty object of the Person class (used a default constructer but now no need as the constructor is defined)
        Person person1 = new Person(37, "Terry", "Sunport", 1.75, 87.6); //Instansiating the person1 object of the Person class
        Person person2 = new Person(31, "Lily", "Turnington", 1.70, 77.5);  //Instansiating the person2 object of the Person class
        person1.Age = 40; //update age of person 1
        person2.LName = "Fletcher"; //Update last name of person 2;
        Console.WriteLine($"\t First Name: {person1.FName}, Last Name: {person1.LName}, Age: {person1.Age} years old");
        Console.WriteLine($"\t First Name: {person2.FName}, Last Name: {person2.LName}, Age: {person2.Age} years old");


        //Test the validation methods of the Person Class properties using Try/Catch Block

        try
          {
               Console.ResetColor(); 
               Console.WriteLine("\n\ttesting invalid inputs");
               Console.WriteLine("\n\ttesting with ages");
               person.Age = 0;
               person.Age = -2;

               Console.WriteLine("\n\ttesting with first names");
               person!.FName = "T";
               person!.FName = "Julia_Poolia_Coolia";

               Console.WriteLine("\n\ttesting with last names");
               person!.LName = "Sunport_lively_town";
               person!.LName = "Tu";
          }
          catch (ArgumentException arg_ex)

          {
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine(arg_ex.ToString());

          }
               Console.ResetColor();
         
         


        //Using the PersonHandler Class methods to instansiate and perform operations on the Person Object

        PersonHandler personHandler = new PersonHandler()!; //Create an object of PersonHandler class


         var personCreated1 = personHandler.CreatePerson(31,"Julia", "Turnpike", 178, 80.3); //Instansiate person1 object using PersonHandler class
         var personCreated2 = personHandler.CreatePerson(40,"Tina", "Johnson", 168, 79.5);   //Instansiate person2 object using PersonHandler class
         var personCreated3 = personHandler.CreatePerson(31, "Simon", "Smith", 169, 85.2);   //Instansiate person3 object using PersonHandler class

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
        
         */



        //Assignment 3 Section 3.2 POLYMORFISM


        /*

         List<UserError> errors = new List<UserError>();
         NumericInputError numericInputError = new NumericInputError();
         TextInputError textInputError = new TextInputError();
         NullInputError nullInputError = new NullInputError();
         TextInputTooLong textInputTooLong = new TextInputTooLong();
         NumericInputTooBig numericInputTooBig = new NumericInputTooBig();

         for (int i = 0; i < 1; i++) //populating the list with instances
         {
             errors.Add(numericInputError); 
             errors.Add(textInputError);
             errors.Add(nullInputError);
             errors.Add(textInputTooLong);
             errors.Add(numericInputTooBig);

         }

         foreach (UserError message in errors)
         {
             Console.WriteLine(message.UEMessage());
         }

         */


        //Assignment 3 Section 3.3 INHERITANCE

        //Q.13 If it's only the birds that should access to the new attribute then I would update the Bird class.
        //Q.14 If all animals should access to the new attribute then I would update the Animal class.

        IPerson horse = new Horse(); 
        Pelican pelican = new Pelican();
        Worm worm = new Worm();
        Wolfman wolfman = new Wolfman();  //  ToDo ?? not following the IPerson thing

        worm.BilaterallySymmetrical = true;
        horse.SleepStandingUp = true;
        pelican.EatFish = 100;

        worm.DoSound();
        horse.DoSound();
        pelican.DoSound();
        wolfman.;

        Console.ResetColor();

        Console.WriteLine(horse.ToString());




        Console.ResetColor();
    }



   



   
}