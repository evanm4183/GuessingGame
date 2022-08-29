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
            int numberOfChances = GetNumberOfChances();
            MultipleChances(numberOfChances, secretNumber);
        }

        static void MultipleChances(int numberOfChances, int secretNumber)
        {
            for(int i = 0; i < numberOfChances; i++)
            {
                Console.WriteLine($"Guesses Left: {numberOfChances - i}");
                int userGuess = GetUserGuess();
                IsSecretNumber(userGuess, secretNumber);

                if (secretNumber < userGuess)
                {
                    Console.WriteLine("Your guess is too high");
                    Console.WriteLine("--------------------------");
                }
                else if (secretNumber > userGuess)
                {
                    Console.WriteLine("Your guess is too low");
                    Console.WriteLine("--------------------------");
                }

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

        static int GetNumberOfChances()
        {
            Console.WriteLine("Choose your difficulty (Easy-1, Medium-2, Hard-3): ");
            int difficulty = int.Parse(Console.ReadLine());

            if (difficulty == 1)
            {
                return 8;
            }
            else if (difficulty == 2)
            {
                return 6;
            }
            else if (difficulty == 3)
            {
                return 4;
            }
            else {
                Console.WriteLine("Not a valid input");
                return 0;
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
