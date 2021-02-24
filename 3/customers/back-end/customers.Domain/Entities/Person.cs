using System;

namespace customers.Domain.Entities
{
    public abstract class Person : BaseEntity<int>
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
