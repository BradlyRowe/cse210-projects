using System;

class Program
{
    static void Main()
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(userName, squaredNumber);
    }

    // Function 1: Displays a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function 2: Prompts for and returns the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function 3: Prompts for and returns the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        return int.Parse(input);
    }

    // Function 4: Squares the number and returns the result
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function 5: Displays the final result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
