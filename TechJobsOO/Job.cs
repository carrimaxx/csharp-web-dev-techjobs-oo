using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)  
        {
            if (obj == this)       
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
       
        public override string ToString()
        {
            return "\nID: " + Id + " \n" + "Name: " + Name + " \n" + EmployerName + EmployerLocation + JobType + JobCoreCompetency;
            //return "\nID: " + Id + " \n" + "Name: " + Name + " \n" + "Employer: " + EmployerName + " \n" + "Location: " + EmployerLocation + " \n" + "Position Type: " + JobType + " \n" + "Core Competency: " + JobCoreCompetency + " \n" ;
        }
    }
}
