using System;
namespace TechJobsOO
{
    abstract public class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }
        public JobField(string val) : this()
        {
            value = val;
        }

        public override bool Equals(object obj)
        {
            return obj is JobField field &&
                   Id == field.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
