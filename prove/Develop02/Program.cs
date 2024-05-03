using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal, promptGenerator);
                    break;
                case "2":
                    DisplayJournal(journal);
                    break;
                case "3":
                    SaveJournalToFile(journal);
                    break;
                case "4":
                    LoadJournalFromFile(journal);
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        Console.WriteLine("Enter your response:");
        string response = Console.ReadLine();

        journal.AddEntry(new Entry(prompt, response));
    }

    static void DisplayJournal(Journal journal)
    {
        Console.WriteLine("Journal entries:");
        journal.DisplayEntries();
    }

    static void SaveJournalToFile(Journal journal)
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved to file.");
    }

    static void LoadJournalFromFile(Journal journal)
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded from file.");
    }
}

        // Classes

        // Journal.cs - Stores entries
            // AddEntry(newEntry : Entry) :  void
            // Display() : void
            // SaveToFile(file : string)
            // LoadFromFile(file : string)
                // Attributes
                // _entries : List<Entry>
                // Methods
                //AddEntry(newEntry : Entry) : void
                // DisplayAll() : void
                // SaveToFile(file : string) : void
                // LoadFromFile(file : string) : void

        // Entry.cs - Represents a single entry
            // Display() : void
                // Attributes
                // _date : string
                // _promptText : string
                // _entryText : string
                // Methods
                // Display() : void

        // PromptGenerator.cs - Generates random prompt
            // GetRandomPrompt() : string
                // Attributes
                // _prompts : List<string>
                // Methods
                // GetRandomPrompt() : string

