// See https://aka.ms/new-console-template for more information

using System;

namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recieving number imput from the user
            Console.WriteLine("Enter a numerical grade between 0 and 100: ");

            //Reading the number inputed and saving to grade variable as an integer 
            int grade = int.Parse(Console.ReadLine());

            //Grade characters
            char gradeLetter;

            //Checking if the inputed number fall in any of the ranges defined
            if (grade >= 90)
            {
                gradeLetter = 'A';
            }
            else if (grade >= 80)
            {
                gradeLetter = 'B';
            }
            else if (grade >= 70)
            {
                gradeLetter = 'C';
            }
            else if (grade >= 60)
            {
                gradeLetter = 'D';
            }
            else
            {
                gradeLetter = 'F';
            }

            //Printing out the grade and the grade letter
            Console.WriteLine($"Numerical Grade: {grade}");
            Console.WriteLine($"Letter Grade: {gradeLetter}");
        }
    }
}


