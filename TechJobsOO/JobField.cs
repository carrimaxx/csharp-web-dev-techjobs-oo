using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        internal static int NextId = 1; //public? abstract?
        public string Value { get; set; }

        //public JobField()
        //{
        //    Id = nextId;
        //    nextId++;
        //}
        public abstract override bool Equals(object obj); // should I add this?

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
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
