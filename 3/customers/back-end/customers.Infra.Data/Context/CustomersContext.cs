using Microsoft.EntityFrameworkCore;

namespace customers.Infra.Data.Context
{
    public class CustomersContext : DbContext
    {
        public CustomersContext(DbContextOptions<CustomersContext> options) : base(options) { }
        
    }
}
