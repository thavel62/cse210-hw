using System;
using System.Collections.Generic;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        // Create a Loop for each job to be displayed
        foreach (Job job in _jobs)
        {
            job.Display(); // Display job as it goes through the list
        }
    }
}