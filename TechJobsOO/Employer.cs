using System;
namespace TechJobsOO
{
    public class Employer
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public Employer()
        {
            Id = nextId;
            nextId++;
        }

        // CHECK OUT  https://stackoverflow.com/questions/1814953/how-to-do-constructor-chaining-in-c-sharp
        // https://www.c-sharpcorner.com/UploadFile/825933/constructor-chaining-in-C-Sharp/

        public Employer(string value) : this() // <-- calls the first constructor also called constructor chaining
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
