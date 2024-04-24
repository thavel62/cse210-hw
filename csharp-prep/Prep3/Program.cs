using System;

class Program
{
    static void Main(string[] args)
    {
        // User given magic number
        // Console.WriteLine("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // Random Number Generator
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 50);
    
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber) 
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it! ");
            }  
        }
    }
}