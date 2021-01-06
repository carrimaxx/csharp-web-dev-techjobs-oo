﻿using System;

namespace TechJobsOO
{
    public class Employer : JobField
    {
        public Employer(string value) : base(value)
        {
        }

  

        public override string ToString()
        {
            if (Value == "")
            {
                return "Employer: Data not available \n";
            }
            else
            {
                return "Employer: " + Value + " \n";
            }
        }
    }
}
