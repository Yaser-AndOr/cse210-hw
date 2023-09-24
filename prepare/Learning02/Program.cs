using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobtitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobtitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Nefi Zaldana";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        Console.ReadKey();
    }
}
public class Job
{
    public string _jobtitle;
    public string _company;
    public int _startYear;
    public int _endYear;
    public void Display()
    {
        Console.WriteLine($"Titulo: {_jobtitle}\n" +
            $"Company: {_company}\n" +
            $"StartYear: {_startYear}\n" +
            $"AndYear: {_endYear}\n");
    }
}

public class Resume
{
    public string _name;
    public List<Job> _jobs;
    public Resume()
    {
        _jobs = new List<Job>();
    }
    public void Display()
    {
        Console.WriteLine($"Name: {_name}\nJobs:\n");
        int i = 0;
        foreach (Job job in _jobs)
        {
            Console.WriteLine($"Job {i++}:");
            job.Display();
        }
    }
}
