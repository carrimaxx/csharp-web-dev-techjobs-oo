using System;
namespace TechJobsOO
{
    public class Location : JobField
    {
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }
        public int ZipCode { get; set; } // added dec25

        //public Location()
        //{
        //    Id = nextId;
        //    nextId++;
        //}

        public Location(string value) : base(value)
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

        //public override string ToString()
        //{
        //    if (Value == "")
        //    {
        //        return " Data not available ";
        //    }
        //    else
        //    {
        //        return " " + Value + " ";
        //    }
        //}
    }
}
