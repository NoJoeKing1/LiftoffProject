using System;

namespace ParkRec.Models
{
    public class Park
    {
        //Park model to store information on each new park object

        public string Name { get; set; }
        public string Location { get; set; }    
        public string Description { get; set; }
        public int Id { get; set; }

        public Park(string name, string location, string description)
        {
            Name = name;
            Location = location;
            Description = description;
        }

        public Park()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Park park &&
                   Id == park.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
