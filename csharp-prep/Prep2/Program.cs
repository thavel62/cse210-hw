using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade percentage? ");
        string score = Console.ReadLine();
        int grade = int.Parse(score);

        string letter = "";

        if (grade >= 90)
        {
            if (grade >= 97)
            {
                letter = "A+";
            }
            if (grade <= 93)
            {
                letter = "A-";
            }
            if (grade > 93 && grade < 97)
            {
                letter = "A";
            }
        }
        else if (grade >= 80)
        {
            if (grade >= 87)
            {
                letter = "B+";
            }
            if (grade <= 83)
            {
                letter = "B-";
            }
            if (grade > 83 && grade < 87)
            {
                letter = "B";
            }
        }
        else if (grade >= 70)
        {
            if (grade >= 77)
            {
                letter = "C+";
            }
            if (grade <= 73)
            {
                letter = "C-";
            }
            if (grade > 73 && grade < 77)
            {
                letter = "C";
            }
        }
        else if (grade >= 60)
        {
            if (grade >= 67)
            {
                letter = "D+";
            }
            if (grade <= 63)
            {
                letter = "D-";
            }
            if (grade > 63 && grade < 67)
            {
                letter = "D";
            }
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed! ");
        }
        else
        {
            Console.WriteLine("Unfortunately you have failed. ");
        }
    }
}