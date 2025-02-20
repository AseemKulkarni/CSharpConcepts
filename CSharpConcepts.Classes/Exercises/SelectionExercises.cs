﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Exercises
{
    public static class SelectionExercises
    {
        // Q1: FizzBuzz
        // Return Fizz if divisible by 3. Buzz if divisible by 5. FizzBuzz if divisible by both.
        // If divisible by neither return the number itself (as a string)
        public static string FizzBuzz(int num)
        {
            string output = Convert.ToString(num);
            if (num % 15 == 0)
                Console.WriteLine("Fizzbuzz");
            else
                if (num % 5 == 0)
                Console.WriteLine("Buzz");
            if (num % 3 == 0)
                Console.WriteLine("Fizz");
            else

                Console.WriteLine($"{output}");

            throw new NotImplementedException();
        }

        // Q2: Vowel or Consonant
        // Using a switch statement write a function which returns true if the input is a vowel and
        // false if it is a consonant
        public static bool VowelOrConsonant(char letter)
        {

            switch (letter)
            {
                case 'a':
                    return false;
                case 'e':
                    return false;
                case ('i'):
                    return false;
                case ('o'):
                    return false;
                case ('u'):
                    return false;
                default:
                    return true;
            }



            throw new NotImplementedException();
        }
    }
}


        // Q3: DiceRoller
        // Write a procedure which rolls three dice and write the following messages to the console
        // If all three dice have the same value write, "Three of a kind"
        // If two of the dice have the same value write, "You have a pair!
        // Otherwise write, "Sorry you lose






        // Q4: Angles
        // Write a function to return whether the angle input is acute, right angle, obtuse, straight or reflex
        // Use an enum for the different angle types

       



        // Q5: Rock, Paper Scissors
        // Write a procedure which takes the user's choice as input and randomly generate the computer's choice
        // It should write the computer's choice to the console and write whether the user lost, won, or drew.
        // Handle the user input in the calling code in Program.cs

        // Q6: Triangle
        // Write a function that takes in three side lengths.
        // Determine whether a triangle with those sides is equilateral, isosceles, scalene or impossible

     