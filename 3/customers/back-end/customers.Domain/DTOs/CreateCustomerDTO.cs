using System;

namespace customers.Domain.DTOs
{
    public class CreateCustomerDTO
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
    }
}
