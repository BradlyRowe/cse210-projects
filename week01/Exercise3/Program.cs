using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Number Guessing Game!");
        do
        {
        int magicNumber = Random.Shared.Next(1, 101);
        int guess = 0;
        int attempts = 0;
            do
            {
                attempts++;
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                guess = int.Parse(input);
                if (guess < magicNumber)
                {
                    Console.WriteLine("Too low");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Too high");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {attempts} guesses!");
                }
            } while (guess != magicNumber);
            Console.Write("Do you want to play again (y/n)? ");
        } while (Console.ReadLine() == "y");
    }
}