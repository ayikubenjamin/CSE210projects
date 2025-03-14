using System.Security.Cryptography.X509Certificates;

public class Resume
{
    public string _name;
    public List <Job> Jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name : {_name}");
        Console.WriteLine("Jobs :");
        foreach (Job Job in Jobs)
        {
            Job.DisplayJobInfo();
        }
    }
}
