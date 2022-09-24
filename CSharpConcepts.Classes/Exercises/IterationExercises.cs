﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Exercises
{
    public static class IterationExercises
    {
        // Q1: Centuries
        // Calculate the number of times a batter scored a century (100 runs) or more in a match
        public static int NumberOfCenturiesScored(List<int> runsScored)
        {
            int total = 0;
            foreach (int run in runsScored)
            {if (run>=100)
                total = total + run;
                
            }
            return total;
            throw new NotImplementedException();
        }

        // Q2: Batting Average
        // Calculate the batting average.
        // Exclude any values where the runs scored were negative as a negative value indicates that they did not bat in that match.
        public static double BattingAverage(List<int> runsScored)
        {
            int total=0;
            int count=0;
            foreach (int run in runsScored.Where(run => run > 0))
            {
                total=total + run;
                count ++;

            }
            return total/count;
           throw new NotImplementedException();
        }

        // Q3: User Names
        // Determine the user names
        // It will be the first three characters of their name and a number, which will be the order of the name in the list.
        public static List<string> UserNames(List<string> names)
        {
            List<string> result = new List<string>();
            int index=0;
            foreach (string name in result)
            {
                string username = ($"{names[i].Substring(0,3)+i}"
                result.Add(username)

            }
            return result
            throw new NotImplementedException();
        }

        // Q4: Calculate Multiples
        // Write a function that will output the multiple of a number from 1 to the max number specified
        // So called with 6 and 10 it would output [6, 12, 18, 24, 30, 36, 42, 48, 54, 50]
        public static List<int> CalculateMultiples(int number, int maximumMultiple)
        {
            
            int multiple = 1;
            List <int> ints = new List<int>();
           { do:
                int num = number*multiple;
                result.add(num)  
                multiple ++;
            while (num < maximumMultiple)

           }
            return ints;
            throw new NotImplementedException();
        }

        // Q5: Is Prime
        // Write a function to determine whether a number is prime



        public static int isprime(int number)
        {
            int i 
            for (i==2,i <= number-1;i++)
                if (number%i==0)
                    return false
                    break
                else:
                    return true
        }


        // Q6: Star Pattern
        // Write a procedure to output a star pattern based on the number of stars input
        // So for example if the user enters 6 then it will output:

        //*
        //**
        //***
        //****
        //*****
        //******
        //*****
        //****
        //***
        //**
        //*
     public static int starpattern (int starnumber)
           
        
{
            for (int i=0; i < starnumber; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i = starnumber; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            




        // Q7: This function should take a noughts and crosses board represented as an character list,
        // A space represents an empty space as shown below.
      


       
       /* List<List<char>> board = new()
        {
            new() { 'X', '0', 'X' },
            new() { ' ', '0', ' ' },
            new() { 'X', '0', ' ' }
        };*/

        // The function should return a char: 'X' if player X has won, '0' if the player 0 has won,
        // and ' ' if there is currently no winner.
    }
}
