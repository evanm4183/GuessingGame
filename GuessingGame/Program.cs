using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;
            Console.WriteLine("Guess the secret number!");

            MultipleChances(4, secretNumber);
        }

        static void MultipleChances(int numberOfChances, int secretNumber)
        {
            for(int i = 0; i < numberOfChances; i++)
            {
                Console.WriteLine($"Guess Number {i + 1}");
                int userGuess = GetUserGuess();
                IsSecretNumber(userGuess, secretNumber);

                if (userGuess == secretNumber)
                {
                    break;
                }
                if (i == numberOfChances - 1)
                {
                    Console.Write($"You used up all {numberOfChances} of your guesses");
                }
            }
        }

        static void IsSecretNumber(int userGuess, int secretNumber)
        {
            if (userGuess == secretNumber)
            {
                Console.WriteLine("You guessed the secret number!");
            }
            else 
            {
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
