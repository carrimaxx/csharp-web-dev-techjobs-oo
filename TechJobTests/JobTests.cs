using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job sampleJob1 = new Job();
            Job sampleJob2 = new Job();
            // Assert.AreEqual(sampleJob1.Id, sampleJob2.Id, 1); // added 1 and the test passed, TODO revisit
            Assert.IsFalse(sampleJob1.Id == sampleJob2.Id); // not sure about this, equals ?
            
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job sampleJob = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));

            Assert.AreEqual("Product Tester", sampleJob.Name);
            Assert.AreEqual("ACME", sampleJob.EmployerName.Value);
            Assert.AreEqual("Desert", sampleJob.EmployerLocation.Value);
            Assert.AreEqual("Quality Control", sampleJob.JobType.Value);
            Assert.AreEqual("Persistence", sampleJob.JobCoreCompetency.Value); // how about id?
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob = new Job(".NET Developer", new Employer("Microsoft"), new Location("New York"), new PositionType("Senior Developer"), new CoreCompetency("C#"));
            Job testJob2 = new Job(".NET Developer", new Employer("Microsoft"), new Location("New York"), new PositionType("Senior Developer"), new CoreCompetency("C#"));

            Assert.IsFalse(testJob.Equals(testJob2));
        }
    }
}
