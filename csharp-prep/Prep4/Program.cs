using System;

class Program
{
    static void Main(string[] args)
    {
        //creation of the empty list
        List <int> numbers;
        numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished");
            Console.Write("Enter number: ");
            
            string answer = Console.ReadLine();
            number = int.Parse(answer);
            if (number != 0)
            {
                numbers.Add (number);
            }
        }
        
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = numbers[0];
        foreach (int j in numbers)
        {
            if (j > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}