using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        
        int userInput = -1;

        while (userInput != 0)
        {
            Console.WriteLine("Enter a number use 0 to quit: ");

            string response = Console.ReadLine();
            userInput = int.Parse(response);
            
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }

        // Calculate the sum of all the numbers in the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum} ");

        // Calculate the average of all the numbers in the list
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average} ");

        // Find the max of the list
        int max = numbers[0];

        foreach (int number in numbers)
        {
            //if statement to find max
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

    }
}