using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Exercises
{
    public static class TypeExercises
    {
        // Q1: Calculator 1
        // Write to the console correctly the results of: +. - , *, /
        public static void Calculator(int num1, int num2)
        {
            {
                Console.WriteLine("in calc int");
                Console.WriteLine($"{num1}*{num2}={num1 * num2}");
                Console.WriteLine($"{num1}+{num2}={num1 + num2}");
                Console.WriteLine($"{num1}-{num2}={num1 - num2}");
                Console.WriteLine($"{num1}/{num2}={num1 / num2}");
            }
          //  throw new NotImplementedException();    
        }

        // Q2: Calculator 2
        // Try to convert both the values to a double and write to the console the results of: +. - , *, /
        public static void Calculator(string value1, string value2)
        {
            {
                   
                Console.WriteLine($"{value1}*{value2}= {Convert.ToDouble(value1) * Convert.ToDouble(value2)}");
                Console.WriteLine($"{value1}-{value2}= {Convert.ToDouble(value1) - Convert.ToDouble(value2)}");
                Console.WriteLine($"{value1}+{value2}= {Convert.ToDouble(value1) + Convert.ToDouble(value2)}");
                Console.WriteLine($"{value1}/{value2}= {Convert.ToDouble(value1) / Convert.ToDouble(value2)}");

            }
           // throw new NotImplementedException();
        }

        // Q3: Binary Strings
        // Write to the console the number printed in Binary, Decimal and Hex formats
        public static void BinaryStrings(int num)
        {
            {
                string b = Convert.ToString(num, 2);
                string d = Convert.ToString(num, 10);
                string h = Convert.ToString(num, 16);
                Console.WriteLine($"{num} in binary is {b}");
                Console.WriteLine($"{num} in Decimalis {d}");
                Console.WriteLine($"{num} in Hex is {h}");
                            }
            //throw new NotImplementedException();
        }

        // Q4: BMI
        // Calculate and return the BMI - Body mass index
        public static double BMICalculator(double height, double weight)
        {
            {
                double BMI = height / weight;
                Console.WriteLine($"BMI is {BMI}");
                return BMI;
            } 
           // throw new NotImplementedException();
        }

        // Q5: FutureDate
        // Write to the console today's date. Return the date that it will be when the days passed in are added to the current date. 
        public static DateTime FutureDate(int days)
        {

            {
                DateTime Today = DateTime.Today;
                DateTime future = Today.AddDays(days);
                Console.WriteLine($"Today's date is {Today} and the date {days} days later is {future}");
                return future;

            }
           // throw new NotImplementedException();
        }
        
        // Q6: Languages
        // Using the enum below write a program that will convert the proposed language to the enum if availabe
        // Otherwise it should randomly assign a language
        public enum Language
        {
            French,
            Italian,
            Spanish,
            Finnish
        }
        public static Language SelectLanguage(string proposedLanguage)
        {
            bool b;
            Random rnd = new Random();
            //Language mylang1;
            b = Enum.TryParse<Language>(proposedLanguage, out Language mylang1);
            if (b == true)
            {   
                Console.WriteLine($"Sucessfully converted to enum {mylang1}");
            }
            else
            {
                mylang1 = (Language)rnd.Next(4);
                Console.WriteLine($"Proposed language does not exist.Randomly assigned language = {mylang1}");
            }

            return mylang1;


            
          //  throw new NotImplementedException();
        }


    }
}
