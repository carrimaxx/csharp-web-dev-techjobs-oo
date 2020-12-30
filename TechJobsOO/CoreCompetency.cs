using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public CoreCompetency() //dec29
        {
            Id = nextId; //dec23
            nextId++; //dec23
        }

        public CoreCompetency(string value) : this()
        {
            Value = value; //dec29 updated
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
            if (Value == "")
            {
                return " Data not available ";
            }
            else
            {
                return " " + Value + " ";
            }
        }
    }
}
