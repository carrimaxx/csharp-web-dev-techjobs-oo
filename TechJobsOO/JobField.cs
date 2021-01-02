using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; set; }
        internal static int nextId = 1; //public? abstract?
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value)
        {
            Value = value;
        }

        public abstract override bool Equals(object obj); // should I add this?

        public abstract override int GetHashCode();
      
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
