﻿using System;

namespace TechJobsOO
{
    public class Location : JobField
    {
        public Location(string value) : base(value)
        {
        }
     

     
        public override string ToString()
        {
            if (Value == "")
            {
                return "Location: Data not available \n";
            }
            else
            {
                return "Location: " + Value + " \n";
            }
        }
    }
}
