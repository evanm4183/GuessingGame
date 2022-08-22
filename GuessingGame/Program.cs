using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number!");
            int userGuess = GetUserGuess();
            DisplayUserGuess(userGuess);
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
