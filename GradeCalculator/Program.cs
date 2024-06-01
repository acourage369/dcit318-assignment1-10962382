// See https://aka.ms/new-console-template for more information

using System;

namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Grade Calculator
            Write a program that prompts the user to enter a numerical grade between 0 and 100. Based
            on the grade entered, display the corresponding letter grade using the following scale:
            - 90 and above: A
            - 80-89: B
            - 70-79: C
            - 60-69: D
            - Below 60: F
            */

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


