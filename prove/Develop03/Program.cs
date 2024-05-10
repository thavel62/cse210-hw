using System;

class Program
{
    static void Main(string[] args)
    {
        // Store reference
        Reference reference = new Reference("Moroni", 10, 3, 5);
        // Store verse
        Scripture scripture = new Scripture(reference, "Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts. And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.");
        // Display scripture
        // Display the initial scripture
        Console.WriteLine("Initial Scripture:");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        // Hide random words until all words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // Hide three words at a time
            Console.WriteLine("Updated Scripture:");
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
        }

        Console.WriteLine("Program ended.");        

    }
}