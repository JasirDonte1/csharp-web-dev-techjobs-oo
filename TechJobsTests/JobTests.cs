using System;
using Xunit;
using TechJobsOO;

namespace TechJobsTests
{
    public class JobTests
    {
        [Fact]
        public void TestSettingJobId()
        {
            //Create two Job objects using the empty constructor. 
            var job1 = new Job();
            var job2 = new Job();
            Assert.NotEqual(job1,job2);
        }

        [Fact]
        public void TestJobConstructorSetsAllFields()
        {
            var job = new Job
            {
                Name = "Product Tester",
                EmployerName = new Employer("ACME"),
                EmployerLocation = new Location("Desert"),
                JobType = new PositionType("Quality Control"),
                JobCoreCompetency = new CoreCompetency("Persistence")
            };
            Assert.Equal("Product Tester",job.Name);
            Assert.Equal("ACME", job.EmployerName.value);
            Assert.Equal("Desert", job.EmployerLocation.value);
            Assert.Equal("Quality Control", job.JobType.value);
            Assert.Equal("Persistence", job.JobCoreCompetency.value);
        }

        [Fact]
        public void TestJobsForEquality()
        {
            var job1 = new Job();
            var job2 = new Job();

            Assert.False(job1.Equals(job2));
        }

        [Fact]
        public void TestJobsToStringForBlankLines()
        {
            var job = new Job
            {
                Name = "Product Tester",
                EmployerName = new Employer("ACME"),
                EmployerLocation = new Location("Desert"),
                JobType = new PositionType("Quality Control"),
                JobCoreCompetency = new CoreCompetency("Persistence")
            };

            Assert.StartsWith("\n",job.ToString());
            Assert.EndsWith("\n",job.ToString());
            
        }

        [Fact]
        public void TestToStringForLables()
        {
            var job = new Job
            {
                Name = "Product Tester",
                EmployerName = new Employer("ACME"),
                EmployerLocation = new Location("Desert"),
                JobType = new PositionType("Quality Control"),
                JobCoreCompetency = new CoreCompetency("Persistence")
            };

            var tString = job.ToString();

            Assert.Contains("Name:", tString);
            Assert.Contains("Employer:", tString);
            Assert.Contains("Location:", tString);
            Assert.Contains("Position Type:", tString);
            Assert.Contains("Core Competency:", tString);

        }

    }
}
