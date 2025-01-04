using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        bool play = true; 

        do
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 101);
            int guess = 0;
            int guessCount = 0;

            do
            {
                Console.Write("What is the magic number? ");
                string userGuessInput = Console.ReadLine();
                guess = int.Parse(userGuessInput);
                guessCount++;

                if (guess > randomNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} tries!");
                }
            } while (guess != randomNumber);

            Console.Write("Want to play again? (Y/N) ");
            string userPlayInput = Console.ReadLine();
            if (string.Equals(userPlayInput.ToLower(), "n"))
            {
                play = false;
            }
        } while (play == true);
    }
}