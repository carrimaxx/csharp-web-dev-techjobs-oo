using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        //public PositionType() 
        //{
        //    Id = nextId;
        //    nextId++;
        // }

        public PositionType(string value) : base(value)
        {
        }

        public override bool Equals(object obj)   
        {
            return obj is PositionType positionType &&
                   Id == positionType.Id;
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
