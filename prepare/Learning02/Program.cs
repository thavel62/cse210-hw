using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); // Create a new job instance named job1
        job1._jobTitle = "Software Engineer"; // set member variable using dot notation
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job(); //Create a 2nd new job instance named job2
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // job1.Display(); // Option to display jobs separately from resume
        // job2.Display(); // Option to display jobs separately from resume

        Resume myResume = new Resume(); // Create a new Resume instance
        myResume._name = "Tyler Havel"; // Member Variable

        myResume._jobs.Add(job1); 
        myResume._jobs.Add(job2);

        myResume.Display(); // Display entire resume with name and job

    }
}