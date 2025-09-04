using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = Random.Shared.Next(1, 101);
        int guess = 0;
        int attempts = 0;
        Console.WriteLine("Welcome to the Number Guessing Game!");
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
    }
}