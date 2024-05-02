using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

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


    }
}