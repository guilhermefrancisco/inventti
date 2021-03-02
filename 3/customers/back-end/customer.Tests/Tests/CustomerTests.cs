using customer.Tests.Infra;
using System.Linq;
using Xunit;

namespace customer.Tests
{
    public class CustomerTests : CustomersTestBase
    {
        [Fact]
        public void ShouldReturnAllCustomers()
        {
            var customers = _context.Customers.ToList();

            Assert.Equal(4, customers.Count);
        }

        [Fact]
        public void ShouldOrderCustomersByName()
        {
            var customers = _context.Customers.ToList();

            Assert.Equal("Celio", customers.OrderBy(x => x.Name).First().Name);
        }
    }
}
