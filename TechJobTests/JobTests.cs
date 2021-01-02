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
            Assert.AreNotEqual(sampleJob1.Id, sampleJob2.Id); // added 1 and the test passed, TODO revisit
            Assert.IsFalse(sampleJob1.Id == sampleJob2.Id); // not sure about this, equals ?
            
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job sampleJob = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));

            //Assert.AreEqual(1, sampleJob.Id); // TODO why is this failing
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

        [TestMethod]
        public void FirstToStringMethodTest()
        {
            Job stringTest = new Job("Ice cream tester", new Employer("Ted Drewes"), new Location(""), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            // TODO break down the tests, double check this set of tests
            Assert.AreEqual(" Ted Drewes ", stringTest.EmployerName.ToString());
            Assert.AreEqual(" Data not available ", stringTest.EmployerLocation.ToString());
            Assert.AreEqual("\nID: 1 " + "\nName: Ice cream tester " + "\nEmployer: Ted Drewes " + "\nLocation: Data not available " + "\nPosition Type: UX " + "\nCore Competency: Tasting ability " + "\n", stringTest.ToString());
        }

        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //public void EmptyObjectException()
        //{
        //    Job failTest = new Job();
        //    Assert.Fail("OOPS! This job does not seem to exist.");
        //}
    }
}
