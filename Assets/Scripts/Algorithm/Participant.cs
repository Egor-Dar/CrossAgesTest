using System;

namespace Algorithm
{
    public class Participant
    {
        public Guid UUID { get;}
        public string Email { get;}
        public string FirstName { get;}
        public string LastName { get;}
        public Participant Receiver { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public Participant(Guid uuid, string email, string firstName, string lastName)
        {
            UUID = uuid;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}