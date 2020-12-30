using System;

namespace TechJobsOO
{
    class Program
    {
        static void Main(string[] args)
        {

            //sample dec29: 
            Employer sample = new Employer("LaunchCode");
            Console.WriteLine(sample.Value);
            Console.WriteLine(sample.Id);

            Location location = new Location("Chicago");
            Console.WriteLine(location.Value);
            Console.WriteLine(location.Id);

            Job testJob = new Job(".NET Developer", new Employer("Microsoft"), new Location("New York"), new PositionType("Senior Developer"), new CoreCompetency("C#"));
            Job testJob2 = new Job(".NET Developer", new Employer("Microsoft"), new Location("New York"), new PositionType("Senior Developer"), new CoreCompetency("C#"));

            Console.WriteLine("test below");
            Console.WriteLine(testJob.Id);
            Console.WriteLine(testJob2.Id);

            Job sampleJob1 = new Job();
            Job sampleJob2 = new Job();

            Console.WriteLine("another test below");
            Console.WriteLine(sampleJob1.Id);
            Console.WriteLine(sampleJob2.Id);
            /*
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));

            List<Job> jobs = new List<Job>();

            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);

            foreach (Job job in jobs)
            {
                Console.WriteLine(job);
            }
            */
        }
    }
}
