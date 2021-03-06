﻿using System;

namespace Methods
{
    class Program
    {
        // Define the method DisplayGreeting
        static void DisplayGreeting()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Welcome to Our Employee Database");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }

        static string PromptForString(string prompt)
        {
            // Send the given prompt to the console
            Console.Write(prompt);

            // Get a string from the user
            var userInput = Console.ReadLine();

            // Send that back!
            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            // Prompt for input
            Console.Write(prompt);

            // Variable to receive parsed number from TryParse
            int userInput;

            // Try to parse the input from ReadLine. If successfull, the variable
            // userInput will have the integer. If a failure, isThisGoodInput will
            // be FALSE.
            var isThisGoodInput = int.TryParse(Console.ReadLine(), out userInput);

            // If we had good input
            if (isThisGoodInput)
            {
                // Return back the actual integer input
                return userInput;
            }
            else
            {
                // Otherwise (isThisGoodInput was false), we got bad input.

                // Show an error message
                Console.WriteLine("Sorry, that isn't a valid input, I'm using 0 as your answer.");

                // Return 0
                return 0;
            }
        }

        static void Main(string[] args)
        {
            // Ask DisplayGreeting method to do it's work
            DisplayGreeting();

            var newEmployee = new Employee();

            newEmployee.Name = PromptForString("What is your name? ");

            newEmployee.Department = PromptForInteger("What is your department number? ");

            // Uses the { set; } aspect of the Salary property to *set* it
            newEmployee.Salary = PromptForInteger("What is your salary, yo, give it in dollars? ");

            // Uses the { get; } aspect of the Salary property to read it back.
            Console.WriteLine($"Hello, {newEmployee.Name} you make {newEmployee.MonthlySalary()} a month.");

            newEmployee.Salary = 100000000;
            Console.WriteLine($"Hello, {newEmployee.Name} now you make {newEmployee.MonthlySalary()} a month.");
        }
    }
}
