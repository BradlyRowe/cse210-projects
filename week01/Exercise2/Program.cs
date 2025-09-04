using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you grade percentage? ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);
        string grademod = "";
        if (gradePercentage % 10 >= 7 && gradePercentage >= 60 && gradePercentage < 95)
        {
            grademod = "+";
        }
        else if (gradePercentage % 10 < 3 && gradePercentage >= 60 && gradePercentage < 95)
        {
            grademod = "-";
        }
        string letterGrade = "";
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your letter grade is: {letterGrade}{grademod}");

    }
}