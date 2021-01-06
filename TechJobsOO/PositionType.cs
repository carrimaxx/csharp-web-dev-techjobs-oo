using System;

namespace TechJobsOO
{
    public class PositionType : JobField
    {
        public PositionType(string value) : base(value)
        {
        }

  

       
        public override string ToString()
        {
            if (Value == "")
            {
                return "Position: Data not available \n";
            }
            else
            {
                return "Position: " + Value + " \n";
            }
        }
    }
}
