// See https://aka.ms/new-console-template for more information
using System;

namespace TriangleTypeIdentifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Triangle Type Identifier
            Write a program that prompts the user to enter three sides of a triangle. Based on the lengths
            of the sides entered, determine and display the type of the triangle. The possible types are:
            - Equilateral: All three sides are equal.
            - Isosceles: Two sides are equal.
            - Scalene: No sides are equal.
            */

            Console.WriteLine("Welcome to my Triangle Type Identifier");
            Console.WriteLine("Enter the lenght of the three sides of the triangle");
            
            //Requesting the lenghts of the Triangle
            Console.WriteLine("Side 1: ");
            int firstSide = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Side 2: ");
            int secondtSide = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Side 3: ");
            int thirdSide = Convert.ToInt32(Console.ReadLine());

            //Checking if the triange is Equilateral, Isosceles, or Scalene. 
            if (firstSide == secondtSide && secondtSide == thirdSide)
            {
                Console.WriteLine("The triangle is an Equiateral Triangle");
            }
            else if (firstSide == thirdSide || firstSide == secondtSide || secondtSide == thirdSide)
            {
                Console.WriteLine("The triangle is an Isosceles Triangle");
            }
            else if (firstSide != secondtSide && firstSide != thirdSide && secondtSide != thirdSide)
            {
                Console.WriteLine("The triangle is a Scalene Triangle");
            }
        }
    }
}