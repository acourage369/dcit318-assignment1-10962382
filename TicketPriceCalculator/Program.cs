// See https://aka.ms/new-console-template for more information

using System;

namespace TicketPriceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ticket Price Calculator
            A movie theater sells tickets for GHC10. However, if a customer is a senior citizen (age 65
            and above) or a child (age 12 and below), they receive a discounted price of GHC7. Write a
            program that prompts the user to enter their age and calculates the ticket price based on the
            age entered. Display the ticket price accordingly.
            */

            Console.WriteLine("Welcome to the Movie Theater Ticket Price Calculator");
            //Input from user
            Console.WriteLine("Enter your age for your tickect price: ");

            //Saving it in the age variable
            int age = Convert.ToInt32(Console.ReadLine());

            //Discount Price
            int discountPrice = 7;

            //Normal price
            int standardPrice = 10;

            //Checking if the user qualify for a discounted price
            if (age > 65 || age < 12)
            {
                Console.WriteLine($"Congratulations, you've qualify the discounted of GHC{discountPrice}");
            }
            else
            {
                Console.WriteLine($"The ticket price is GHC{standardPrice}");
            }
        }
    }
}

