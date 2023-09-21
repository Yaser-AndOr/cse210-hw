using System;

class Program
{
    static void Main(string[] args)
    {
        //creation of the empty list
        List <int> numbers = new List<int>();
        int usernum = -1;
        while (usernum != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished");
            Console.Write("Enter number: ");
            
            string answer = Console.ReadLine();
            usernum = int.Parse(answer);
            if (usernum != 0)
            {
                numbers.Add (usernum);
            }
        }
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}