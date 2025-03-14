using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "google";
        job1._jobtitle = "software engineer";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._company = "Amazon";
        job2._jobtitle ="devops engineer";
        job2._startYear = 2022;
        job2._endYear = 2026;

        //job1.DisplayJobInfo();
        //job2.DisplayJobInfo();

        Resume Resume1 = new Resume();
        Resume1._name = "Benjamin Ayiku";
        Resume1.Jobs.Add(job1);
        Resume1.Jobs.Add(job2);
        
        Resume1.DisplayResume();
    }
}