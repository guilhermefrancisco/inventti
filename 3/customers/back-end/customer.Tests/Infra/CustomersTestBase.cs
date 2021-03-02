using customers.Domain.Entities;
using customers.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace customer.Tests.Infra
{
    public class CustomersTestBase : IDisposable
    {
        protected readonly CustomersContext _context;

        public CustomersTestBase()
        {
            var options = new DbContextOptionsBuilder<CustomersContext>()
                .UseInMemoryDatabase(databaseName: "customersDB")
                .Options;

            _context = new CustomersContext(options);

            _context.Database.EnsureCreated();

            Seed(_context);
        }

        private void Seed(CustomersContext context)
        {
            var customers = new Customer[]
            {
                new Customer("Guilherme", "guilherme2017@gmail.com", new DateTime(2000, 7, 06)),
                new Customer("Francisco", "francis2017@gmail.com", new DateTime(2000, 7, 06)),
                new Customer("Odete", "odete@gmail.com", new DateTime(1963, 4, 28)),
                new Customer("Celio", "celio@gmail.com", new DateTime(1960, 6, 30)),
            };

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }
    }
}
