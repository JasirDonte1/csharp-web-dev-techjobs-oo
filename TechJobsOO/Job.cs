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
        public Job(string name, Employer employer, Location location, PositionType positionType, CoreCompetency competency) : this()
        {
            Name = name;
            EmployerName = employer;
            EmployerLocation = location;
            JobType = positionType;
            JobCoreCompetency = competency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
     
        public override string ToString()
        {
            string tName, tEmployer, tLocation, tType, tCompetency; //t = temporary
            bool data_available = false; 
            if (!string.IsNullOrEmpty(Name))
            {
                tName = Name;
                data_available = true;
            }
            else
            {
                tName = "Data Not Available";
            }
            if (!string.IsNullOrEmpty(EmployerName.Value))
            {
                tEmployer = EmployerName.Value;
                data_available = true;

            }
            else
            {
                tEmployer = "Data Not Available";
            }
            if (!string.IsNullOrEmpty(JobType.Value))
            {
                tType = JobType.Value;
                data_available = true;

            }
            else
            {
                tType = "Data Not Available";
            }
            if (!string.IsNullOrEmpty(JobCoreCompetency.ToString()))
            {
                tCompetency = JobCoreCompetency.ToString();
                data_available = true;

            }
            else
            {
                tCompetency = "Data Not Available";
            }
            if (!string.IsNullOrEmpty(EmployerLocation.Value))
            {
                tLocation = EmployerLocation.Value;
                data_available = true;

            }
            else
            {
                tLocation = "Data Not Available";
            }

            if (!data_available)
            {
                return "\nOOPS! This job does not seem to exist.\n";
            }
            else
            {
                return $"\nID: {Id} \nName: {tName} \nEmployer: {tEmployer} \nLocation: {tLocation} \nPosition Type: {tType} \nCore Competency: {tCompetency}\n";

            }
        }

      

    }
}
