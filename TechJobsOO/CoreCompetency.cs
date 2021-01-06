using System;

namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {
        public CoreCompetency(string value) : base(value)
        {
        }

    

    
        public override string ToString()
        {
            if (Value == "")
            {
                return "Core Competency: Data not available \n";
            }
            else
            {
                return "Core Competency: " + Value + " \n";
            }
        }

    }
}
