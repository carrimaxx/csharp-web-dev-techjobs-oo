using System;
namespace TechJobsOO
{
    public class Location
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }
        public int ZipCode { get; set; } // added dec25

        public Location()
        {
            Id = nextId;
            nextId++;
        }

        // TODO Add properties and custom methods as needed to the Location, CoreCompetency, and PositionType classes.

        public Location(string value) : this() // dec 29, pretty sure this is right
        {
            Value = value;
        }
        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        //public override string ToString()     // commented out to test dec29
        //{
        //    return Value;
        //}
    }
}
