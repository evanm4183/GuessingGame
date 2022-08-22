using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 100);

            Console.WriteLine("Guess the secret number!");
            MultipleChances(4, secretNumber);
        }

        static void MultipleChances(int numberOfChances, int secretNumber)
        {
            for(int i = 0; i < numberOfChances; i++)
            {
                Console.WriteLine($"Guesses Left: {numberOfChances - i}");
                int userGuess = GetUserGuess();
                IsSecretNumber(userGuess, secretNumber);

                if (userGuess == secretNumber)
                {
                    break;
                }
                if (i == numberOfChances - 1)
                {
                    Console.Write($"You used up all {numberOfChances} of your guesses. The secret number was {secretNumber}");
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
            Console.Write("Enter a number (1-100): ");
            int userGuess = int.Parse(Console.ReadLine());

            return userGuess;
        }

        static void DisplayUserGuess(int userGuess) 
        {
            Console.WriteLine($"You guessed {userGuess}");
        }
    }
}
