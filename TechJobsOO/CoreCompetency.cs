using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        // commented out original code dec23:
        //private int id;
        //private static int nextId = 1;
        //private string value;

        // TODO: Change the fields to auto-implemented properties.
        // dec 23:
        public int Id { get; set; }
        public static int MyProperty { get; set; } = 1;
        public string Value { get; set; }

        public CoreCompetency(int nextId) //dec23
        {
            Id = nextId; //dec23
            nextId++; //dec23
        }

        public CoreCompetency(string v) : this()
        {
            Value = v; //dec23
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id; //dec23
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id); //dec23
        }

        public override string ToString()
        {
            return Value;
        }
    }
    }
}
