using customers.Domain.Entities;
using customers.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace customers.Infra.Data.Context
{
    public class CustomersContext : DbContext
    {
        public CustomersContext(DbContextOptions<CustomersContext> options) : base(options) { }   
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Customer>(new CustomerMap().Configure);
        }
    }
}
