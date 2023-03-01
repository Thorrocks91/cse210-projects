using System;

class Program
{
    static void Main(string[] args)
    {
        //instances for job1: step 4. 
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear =2021;

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Apple";
        job2._startYear = 2021;
        job2._endYear =2023;


        //step 5: creating instance for resume.
        Resume resume  = new Resume();
        resume._name ="Tiffany Horrocks";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}