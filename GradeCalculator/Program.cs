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
            char letterGrade;

            //Checking if the inputed number fall in any of the ranges defined 
            if (grade >= 90)
            {
                letterGrade = 'A';
            }
            else if (grade >= 80)
            {
                letterGrade = 'B';
            }
            else if (grade >= 70)
            {
                letterGrade = 'C';
            }
            else if (grade >= 60)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }

            Console.WriteLine($"Numerical Grade: {grade}");
            Console.WriteLine($"Letter Grade: {letterGrade}");
        }
    }
}


