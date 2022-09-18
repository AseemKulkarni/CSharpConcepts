using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using CSharpConcepts.Classes.Exercises;

namespace CSharpConcepts
{
    internal class Exercises
    {
        internal static void Run()
        {
            CallTypeExercises();
            //CallSelectionExercises();
        }

        private static void CallTypeExercises()
        {
            // Add your calling code here for the questions an example is below
            TypeExercises.Calculator(15, 5);
            Console.WriteLine();
            TypeExercises.Calculator("15.1", "5.2");
            Console.WriteLine();
            TypeExercises.BinaryStrings(15);
            Console.WriteLine();
            TypeExercises.BMICalculator(5.9, 92.5);
            TypeExercises.FutureDate(5);
            TypeExercises.SelectLanguage("Marathi");
            //Console.WriteLine("# Calculator");
            //TypeExercises.Calculator(12, 5);
            //Console.WriteLine();
        }

        private static void CallSelectionExercises()
        {
         

            
            
            // Add your calling code here for the selection questions
        }
    }
}
