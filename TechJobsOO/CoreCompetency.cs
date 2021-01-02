﻿using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {
        public CoreCompetency(string value) : base(value)
        {
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
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
