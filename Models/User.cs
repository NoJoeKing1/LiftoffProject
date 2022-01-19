using System;

namespace NationalParkRecommendation.Models
{
    public class User
    {
        //User model to store information on each new user object

        public string Name { get; set; }
        public string ContactEmail { get; set; }
        /*public string Password { get; set; }*/
        public int Id { get; set; }

        public User(string name, string contactEmail, int id)
        {
            Name = name;
            ContactEmail = contactEmail;
            Id = id;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Id == user.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
