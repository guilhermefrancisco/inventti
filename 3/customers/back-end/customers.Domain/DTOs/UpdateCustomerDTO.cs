using System;

namespace customers.Domain.DTOs
{
    public class UpdateCustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
    }
}
