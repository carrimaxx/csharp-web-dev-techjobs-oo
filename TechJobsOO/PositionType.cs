﻿using System;
namespace TechJobsOO
{
    public class PositionType
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            Value = value;
        }

           // TODO Add properties and custom methods as needed to the Location, CoreCompetency, and PositionType classes.

        public override bool Equals(object obj)         // equals and gethashcode, tostring override added dec25
        {
            return obj is PositionType positionType &&
                   Id == positionType.Id;
        }

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
