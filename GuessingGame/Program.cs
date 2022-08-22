﻿using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number!");
            int userGuess = GetUserGuess();
            
            int secretNumber = 42;

            if (userGuess == secretNumber)
            {
                Console.WriteLine("You guessed the secret number!");
            }
            else {
                Console.WriteLine("You guessed incorrectly");
            }
        }

        static int GetUserGuess()
        {
            Console.Write("Enter a number: ");
            int userGuess = int.Parse(Console.ReadLine());

            return userGuess;
        }

        static void DisplayUserGuess(int userGuess) 
        {
            Console.WriteLine($"You guessed {userGuess}");
        }
    }
}
