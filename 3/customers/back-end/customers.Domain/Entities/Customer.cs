using System;

namespace customers.Domain.Entities
{
    public class Customer : Person
    {
        public Customer(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public Customer() { }

        public string Email { get; set; }
    }
}
