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
      
            Assert.AreNotEqual(sampleJob1.Id, sampleJob2.Id);
            Assert.IsFalse(sampleJob1.Id == sampleJob2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job sampleJob = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));

            Assert.AreEqual("Product Tester", sampleJob.Name);
            Assert.AreEqual("ACME", sampleJob.EmployerName.Value);
            Assert.AreEqual("Desert", sampleJob.EmployerLocation.Value);
            Assert.AreEqual("Quality Control", sampleJob.JobType.Value);
            Assert.AreEqual("Persistence", sampleJob.JobCoreCompetency.Value); 
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob = new Job(".NET Developer", new Employer("Microsoft"), new Location("New York"), new PositionType("Senior Developer"), new CoreCompetency("C#"));
            Job testJob2 = new Job(".NET Developer", new Employer("Microsoft"), new Location("New York"), new PositionType("Senior Developer"), new CoreCompetency("C#"));

            Assert.IsFalse(testJob.Equals(testJob2));
        }

        [TestMethod]
        public void FirstToStringMethodTest()
        {
            Job stringTest = new Job("Ice cream tester", new Employer("Ted Drewes"), new Location(""), new PositionType("UX"), new CoreCompetency("Tasting ability"));
    
            Assert.AreEqual("Employer: Ted Drewes \n", stringTest.EmployerName.ToString());
            Assert.AreEqual("Location: Data not available \n", stringTest.EmployerLocation.ToString());
            Assert.AreEqual("\nID: 1 \n" + "Name: Ice cream tester \n" + "Employer: Ted Drewes \n" + "Location: Data not available \n" + "Position: UX \n" + "Core Competency: Tasting ability \n", stringTest.ToString());
        }
    }
}
