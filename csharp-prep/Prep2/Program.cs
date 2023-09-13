using System;

class Program
{
    static void Main(string[] args)
    {
        //User interaction to ask the grade percentage
        Console.Write("Write the grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);
        string letter = "";
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("You did pass the course!");
        }
        else
        {
            Console.WriteLine("Sorry, did not pass :( ");
        }
    }
}    